﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Core
{
    /// <summary>
    /// Extensions for IEnumerable interface.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Extends a IEnumerable by single elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="added"></param>
        /// <returns></returns>
        public static IEnumerable<T> Plus<T>(this IEnumerable<T> @this, params T[] added)
        {
            return @this.Concat(added);
        }

        public static void AddRange<T>(this ICollection<T> _this, IEnumerable<T> range)
        {
            foreach (var element in range)
                _this.Add(element);
        }
    }
}
