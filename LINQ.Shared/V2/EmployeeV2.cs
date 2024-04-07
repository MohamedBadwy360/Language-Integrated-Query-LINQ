
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Shared.V2
{
    public class EmployeeV2
    {
        public string EmployeeNo { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public decimal Salary { get; set; }

        public List<string> Skills { get; set; } = new List<string>();


        public override string ToString()
        {

            return
                    $"" +
                    $"{EmployeeNo.PadRight(13, ' ')}\t" +
                    $"{Name.PadRight(20, ' ')}\t" +
                    $"{Email.PadRight(32, ' ')}\t" +
                    $"{string.Format("{0:C0}", Salary)}  " +
                    $"[ {string.Join(", ", Skills)} ]";

        }
    }


}
