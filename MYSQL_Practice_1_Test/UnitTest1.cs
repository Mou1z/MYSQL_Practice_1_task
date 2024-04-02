using MySql.Data.MySqlClient;

namespace MYSQL_Practice_1_Test
{
    [TestClass]
    public class MYSQL_Practice_1_Tests
    {
        [TestMethod]
        public void TestDatabasePopulation()
        {
            string connectionString = MYSQL_Practice_1.connectionString;

            MYSQL_Practice_1.PopulateDatabase();

            bool isTableCreated = TableExists(connectionString, "teachers");
            Assert.IsTrue(isTableCreated);

            Assert.IsTrue(RecordExists(connectionString, "teachers", "name", "John Smith"));
            Assert.IsTrue(RecordExists(connectionString, "teachers", "name", "Anna Johnson"));
            Assert.IsTrue(RecordExists(connectionString, "teachers", "name", "Robert Davis"));
        }

        private bool TableExists(string connectionString, string tableName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"SHOW TABLES LIKE '{tableName}'", connection);
                object tableExists = cmd.ExecuteScalar();
                return (tableExists != null && tableExists.ToString() == tableName);
            }
        }

        private bool RecordExists(string connectionString, string tableName, string columnName, string columnValue)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = '{columnValue}'", connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}