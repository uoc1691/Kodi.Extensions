using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Linq.Extensions
{
    public static class LinqExtensionHelper
    {
        private static Random randomNumber = new Random();

        private static IEnumerable<T> ShuffleFisherYates<T>(IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException();

            var a = source.ToArray();

            for (int i = a.Length - 1; i > 0; i--)
            {
                var j = randomNumber.Next(i + 1);

                var temp = a[j];
                a[j] = a[i];
                a[i] = temp;
            }

            return a.ToList();
        }

        /// <summary>
        /// Extension method that will Shuffle the list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">List to be shuffled</param>
        /// <returns>An IEnumerable</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return ShuffleFisherYates(source);
        }
    }
}
