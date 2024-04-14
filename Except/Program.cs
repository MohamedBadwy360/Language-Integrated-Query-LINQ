﻿using LINQ.Shared.V7;
using System.ComponentModel.DataAnnotations;

namespace Except
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"Meeting 1 Participants {set1.Count}");
            set2.Print($"Meeting 2 Participants {set2.Count}");

            var set3 = set1.Except(set2);
            set3.Print($"set1.Except(set2) {set3.Count()}");

            var set4 = set1.ExceptBy(set2.Select(e => e.EmployeeNo), e => e.EmployeeNo);
            set4.Print($"set1.ExceptBy(set2.Select(e => e.EmployeeNo), e => e.EmployeeNo) {set4.Count()}");
        }
    }
}
