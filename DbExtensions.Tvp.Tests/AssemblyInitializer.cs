using DbExtensions.Tvp.Metadata;
using DbExtensions.Tvp.Metadata.Contracts;

using DbExtensions.Tvp.Tests.Rows;

using System.Reflection;

using System.Runtime.CompilerServices;

namespace DbExtensions.Tvp.Tests
{
    internal static class AssemblyInitializer
    {
        [ModuleInitializer]
        public static void InitMetadata()
        {
            MetadataStorage.AddColumns(typeof(ExternalMetadataTableValued).GetCustomAttribute<TableMetadataAttribute>().Name, new IColumnExternalMetadata[]
            {
                new ColumnExternalMetadata(default, true , nameof(ExternalMetadataTableValued.Property0), typeof(int)   , 5, -1, false),
                new ColumnExternalMetadata(default, true , nameof(ExternalMetadataTableValued.Property1), typeof(int)   , 4, -1, false),
                new ColumnExternalMetadata(default, false, nameof(ExternalMetadataTableValued.Property2), typeof(int)   , 3, -1, false),
                new ColumnExternalMetadata(default, false, nameof(ExternalMetadataTableValued.Property3), typeof(int)   , 2, -1, false),
                new ColumnExternalMetadata(default, false, nameof(ExternalMetadataTableValued.Property4), typeof(string), 1, -1, false),
                new ColumnExternalMetadata(default, false, nameof(ExternalMetadataTableValued.Property5), typeof(string), 0, -1, false)
            });
        }
    }
}