using System.Data.SqlClient;

namespace WinFormsApp1
{
    class Controller
    {
        readonly string connectionString;
        SqlConnection cnn = null;
        public Controller()
        {
            connectionString = "Server = DESKTOP-5I7LOLJ\\SQLEXPRESS; " +
                                       "Trusted_Connection=true;" +
                                       "Database=Northwind;" +
                                       "User Instance=false;" +
                                       "Connection timeout=30";
        }

        //Constructor that takes Controller connection string
        public Controller(string conn)
        {

            connectionString = conn;
        
        }

        //Method to get the customer table count
        public string GetCustomerCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }




            //Method to get company names
            public string GetCompanyNames()
            {
                string names = "None";
                SqlDataReader dataReader;

                cnn = new SqlConnection(connectionString);
                cnn.Open();
                string countQuery = "select companyname from customers;";
                SqlCommand cmd = new SqlCommand(countQuery, cnn);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read()) 
                {
                    try
                    {
                        names = names + dataReader.GetValue(0) + "\n";
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                
                return names;
                            
            }
        }
    }


