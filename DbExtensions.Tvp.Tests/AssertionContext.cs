using DbExtensions.Tvp.Metadata.Contracts;

using DbExtensions.Tvp.Parameters;

using DbExtensions.Tvp.Tests.Rows;

using System;
using System.Collections.Generic;

using System.Data.Common;

using System.Threading.Tasks;

namespace DbExtensions.Tvp.Tests
{
    public static class AssertionContext
    {
        /// <summary>
        /// Creates data rows, builds a parameter from
        /// them, and executes the specified assertion
        /// using both.
        /// </summary>
        public static async Task ExecuteAsync<TRow, TParameter>(Func<IEnumerable<TRow>, TParameter, Task> assertion) where TRow : ITableValued
        {
            IEnumerable<TRow> rows = RowsFactory.Create<TRow>();

            using (IDisposable parameter = rows.Build(typeof(TParameter).IsAssignableTo(typeof(DbDataReader))))
            {
                await assertion(rows, (TParameter)parameter);
            }
        }
    }
}