using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Xunit;

namespace ConnectionStringTest
{
    public class Tests
    {
        [Fact]
        public async Task TestConnectionString_ValidConnectionString_NoException()
        {
            string connectionString = @"";

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
            }
            
            Assert.True(true);
        }
    }
}