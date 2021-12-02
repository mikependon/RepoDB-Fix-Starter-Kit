using Microsoft.Data.SqlClient;
using System.Data;

namespace RepoDb.Fix.StarterKit.Repositories
{
    public class TesterRepository
    {
        private readonly string _connectionString = "Server=.;Database=TestDB;Integrated Security=SSPI;";

        private IDbConnection GetConnection() =>
            new SqlConnection(_connectionString);

        public void Test()
        {
            using (var connection = GetConnection())
            {
                // Do the call here
                throw new NotImplementedException();
            }
        }

        public async Task TestAsync(CancellationToken cancellationToken = default)
        {
            using (var connection = GetConnection())
            {
                // Do the async call here
                throw new NotImplementedException();
            }
        }
    }
}
