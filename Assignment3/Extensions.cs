using System;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach(var list in items) {
                foreach(var item in list) {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach(var item in items) {
                if (predicate.Invoke(item)) {
                    yield return item;
                }
            }
        }
    }
}
