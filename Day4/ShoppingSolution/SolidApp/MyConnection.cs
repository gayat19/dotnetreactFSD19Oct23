using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp
{
    public sealed class MyConnection
    {
        private static MyConnection connection;
       
        private MyConnection()
        {
        }
        public static MyConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MyConnection();
            }
            return connection;
        }
    }
}
