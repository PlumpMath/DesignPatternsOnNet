using System.Collections.Generic;

namespace DesignPatterns._01_PatternsOfBehavior_Chapter1.Strategy.InterfaceVsDelegate
{
    public class EmployeeByIdComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
