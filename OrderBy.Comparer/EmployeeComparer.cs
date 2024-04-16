using LINQ.Shared.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy.Comparer
{
    internal class EmployeeComparer : IComparer<EmployeeV2>
    {
        public int Compare(EmployeeV2? e1, EmployeeV2? e2)
        {
            // "2017-FI-1343"

            int e1Year = Convert.ToInt32(e1?.EmployeeNo.Split("-")[0]);
            int e2Year = Convert.ToInt32(e2?.EmployeeNo.Split("-")[0]);
            int e1Seq = Convert.ToInt32(e1?.EmployeeNo.Split("-")[2]);
            int e2Seq = Convert.ToInt32(e2?.EmployeeNo.Split("-")[2]);

            if (e1Year == e2Year)
            {
                return e1Seq.CompareTo(e2Seq);
            }
            else
            {
                return e1Year.CompareTo(e2Year);
            }
        }
    }
}
