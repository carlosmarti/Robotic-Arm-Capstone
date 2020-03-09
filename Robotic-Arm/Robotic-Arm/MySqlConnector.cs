public class MySqlConnector
    {
        MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        /// <summary>
        /// This class will create a MySQL Connector Object. After the object is created, a query needs to be passed in 
        /// as a parameter and it will be executed against the chosen server.
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="Database"></param>
        /// <param name="User"></param>
        /// <param name="Password"></param>
        public MySqlConnector(string Server, string Database, string User, string Password)
        {
            server = Server;
            database = Database;
            uid = User;
            password = Password;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + " convert zero datetime = True; SslMode=none";
            connection = new MySqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            try
            {
                connection?.Open();
            }
            catch (MySqlException exp)
            {
                throw new Exception("Could not open MySQL Connection connection!", exp);
            }
        }

        private void CloseConnection()
        {
            try
            {
                connection?.Close();
            }
            catch (MySqlException exp)
            {
                throw new Exception("Could not close MySQL Connection connection!", exp);
            }
        }

        public DataTable Select(string SlectStatement)
        {
            try
            {
                DataTable retVal = new DataTable();

                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(SlectStatement, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the first record
                if (!dataReader.Read())
                {
                    CloseConnection();
                    throw new NoRecordsFoundException("Records not Found!");
                }

                //Add appropriate number of columns and set all column names
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    DataColumn Column = new DataColumn(dataReader.GetName(i));
                    // must set the correct datatypes - handle DBNullValues
                    if (dataReader.IsDBNull(i))
                    {
                        Column.DataType = Type.GetType("System.String");
                    }
                    else
                    {
                        Column.DataType = dataReader[i].GetType();
                    }
                    retVal.Columns.Add(Column);
                }
                //Get the rest of the data (use do while because first row is already fetched above)
                do
                {
                    List<object> row = new List<object>();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        row.Add(dataReader[i]);
                    }
                    retVal.Rows.Add(row.ToArray());
                } while (dataReader.Read());

                dataReader.Close();
                CloseConnection();
                return retVal;
            }
            catch(Exception exp)
            {
                CloseConnection();
                throw exp;
            }
        }
        public void Insert(string InsertStatement)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = InsertStatement;
                cmd.Connection = connection;
                cmd.CommandTimeout = 3600; //one hour timeout
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception exp)
            {
                CloseConnection();
                throw exp;
            }

        }

        //Update statement
        public void Update(string UpdateStatement)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = UpdateStatement;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception exp)
            {
                CloseConnection();
                throw exp;
            }

        }

        public void Execute(string Statement)
        {
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = Statement;
                cmd.Connection = connection;
                cmd.CommandTimeout = 3600; //one hour timeout
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception exp)
            {
                CloseConnection();
                throw exp;
            }
        }

        //Delete statement
        public void Delete(string DeleteStatement)
        {
            try
            {
                if (DeleteStatement.ToUpper().IndexOf("WHERE") < 0)
                {
                    throw new Exception("Your DELETE statement is missing a WHERE clause. DELETE aborted. You're welcome.");
                }
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = DeleteStatement;
                cmd.Connection = connection;
                cmd.CommandTimeout = 3600; //one hour timeout
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
            catch (Exception exp)
            {
                CloseConnection();
                throw exp;
            }
        }
    }
