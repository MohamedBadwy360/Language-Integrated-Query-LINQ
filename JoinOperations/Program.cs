using LINQ.Shared.V5;

namespace JoinOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunJoin();
            //RunJoinQuerySyntax();
            //RunGroupJoin();
            RunGroupJoinQuerySyntax();
        }

        

        private static void RunJoin()
        {
            var departments = Repository.LoadDepartment();
            var employees = Repository.LoadEmployees();

            var result = employees.Join(
                departments,
                emp => emp.DepartmentId,
                dept => dept.Id,
                (emp, dept) => new EmployeeDto
                {
                    FullName = emp.FullName,
                    Department = dept.Name
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FullName} => [{item.Department}]");
            }
        }

        private static void RunJoinQuerySyntax()
        {
            var departments = Repository.LoadDepartment();
            var employees = Repository.LoadEmployees();

            var result = from emp in employees
                         join dept in departments on emp.DepartmentId equals dept.Id
                         select new EmployeeDto
                         {
                             FullName = emp.FullName,
                             Department = dept.Name
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FullName} => [{item.Department}]");
            }
        }

        private static void RunGroupJoin()
        {
            var departments = Repository.LoadDepartment();
            var employees = Repository.LoadEmployees();

            var result = departments.GroupJoin(
                employees,
                dept => dept.Id,
                emp => emp.DepartmentId,
                (dept, emps) => new Group
                {
                    Department = dept.Name,
                    Employees = emps.Select(e => e.FirstName).ToList()
                }
                );

            foreach (Group group in result)
            {
                Console.WriteLine($"----- {group.Department} -----");
                foreach (string employee in group.Employees)
                {
                    Console.WriteLine($"\t\t\t {employee}");
                }
            }
        }

        private static void RunGroupJoinQuerySyntax()
        {
            var departments = Repository.LoadDepartment();
            var employees = Repository.LoadEmployees();

            var result = from dept in departments
                         join emp in employees
                         on dept.Id equals emp.DepartmentId
                         into empGroup
                         select empGroup;

            foreach (var group in result)
            {
                Console.WriteLine("----- group -----");
                foreach (var employee in group)
                {
                    Console.WriteLine($"\t\t\t {employee.FullName}");
                }
            }
        }
    }
}
