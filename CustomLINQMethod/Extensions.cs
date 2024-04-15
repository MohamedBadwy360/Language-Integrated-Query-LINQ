using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQMethod
{
    public static class Extensions
    {
        private static Random random = new Random();

        public static IEnumerable<TSource> Paginate<TSource>(this IEnumerable<TSource> source, 
            int page = 1, int pageSize = 10)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)}");
            }

            if (page <= 0)
            {
                //page = 1;
                throw new ArgumentException($"{nameof(page)}");
            }

            if (pageSize <= 0)
            {
                //pageSize = 10;
                throw new ArgumentException($"{nameof(pageSize)}");
            }

            if (!source.Any())
            {
                return Enumerable.Empty<TSource>();
            }

            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }

        public static IEnumerable<TSource> Paginate2<TSource>(this IEnumerable<TSource> source, 
            int? page, int? pageSize)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)}");
            }

            if (!page.HasValue)
            {
                page = 1;
            }
            
            if (!pageSize.HasValue)
            {
                pageSize = 10;
            }

            if (page <= 0)
            {
                //page = 1;
                throw new ArgumentException($"{nameof(page)}");
            }

            if (pageSize <= 0)
            {
                //pageSize = 10;
                throw new ArgumentException($"{nameof(pageSize)}");
            }

            if (!source.Any())
            {
                return Enumerable.Empty<TSource>();
            }

            return source.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
        }

        public static IEnumerable<TSource> WhereWithPaginate<TSource>(this IEnumerable<TSource> source,
            Func<TSource, bool> predicate,
            int page, int pageSize)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)}");
            }

            if (predicate is null)
            {
                throw new ArgumentNullException($"{nameof(predicate)}");
            }

            var result = source.Where(predicate);

            return result.Paginate(page, pageSize);
        }

        public static TSource Random<TSource>(this IEnumerable<TSource> source, 
            Func<TSource, bool> predicate)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)}");
            }

            if (predicate is null)
            {
                throw new ArgumentNullException($"{nameof(predicate)}");
            }

            if (!source.Any())
            {
                return default;
            }

            var result = source.Where(predicate);

            return result.ElementAt(random.Next(0, result.Count()));
        }
    }
}
