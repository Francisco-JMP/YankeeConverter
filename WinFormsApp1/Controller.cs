using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Controller
    {
        public Controller()
        {
            connectionString = "Server = DESKTOP-5I7LOLJ\\SQLEXPRESS; " +
                                       "Trusted_Connection=true;" +
                                       "Datbase=Northwind;" +
                                       "User Instance=false;" +
                                       "Connection timeout=30" +
        }

        //Constructor that takes Controller connection string
        public Controller(string conn)
        {
            connectionString = conn;
        }

        //Method to get the customer table count

    }
}
