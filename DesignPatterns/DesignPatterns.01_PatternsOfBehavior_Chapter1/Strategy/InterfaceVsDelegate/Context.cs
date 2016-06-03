using System;
using System.Collections.Generic;

namespace DesignPatterns._01_PatternsOfBehavior_Chapter1.Strategy.InterfaceVsDelegate
{
    public static class Context
    {
        /// <summary>
        /// List<T>.Sort может принимать, как стратегию на основе интерфейса, так и
        /// стратегию на основе делегата.
        /// </summary>
        public static void SortList()
        {
            var list = new List<Employee>();

            // Используем "функтор" (Стратегия на основе интрфейса)
            list.Sort(new EmployeeByIdComparer());

            // Используем делегат (Стратегия на основе делегата)
            list.Sort((x, y) => x.Id.CompareTo(y.Id));
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SortedListSortedSet()
        {
            var set = new
                SortedSet<Employee>(new EmployeeByIdComparer());
            
            var set1 = new
                SortedSet<Employee>(ComparerFactory.Create<Employee>((x, y) => x.Id.CompareTo(y.Id)));
        }
    }

    /// <summary>
    /// Фабричный класс для создания экземпляров IComparer
    /// </summary>
    public class ComparerFactory
    {
        public static IComparer<T> Create<T>(Comparison<T> comparer)
        {
            return new DelegateComparer<T>(comparer);
        }

        private class DelegateComparer<T> : IComparer<T>
        {
            private readonly Comparison<T> _comparer;

            public DelegateComparer(Comparison<T> comparer)
            {
                _comparer = comparer;
            }

            public int Compare(T x, T y)
            {
                return _comparer(x, y);
            }
        }
    }
}
