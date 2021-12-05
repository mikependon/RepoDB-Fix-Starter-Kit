using RepoDb.Fix.StarterKit.Models;

namespace RepoDb.Fix.StarterKit
{
    public class Initializer
    {
        public static void Initialize()
        {
            SqlServerBootstrap.Initialize();

            FluentMapper
                .Entity<EntityModel>()
                .Table("<TableName>");
        }
}