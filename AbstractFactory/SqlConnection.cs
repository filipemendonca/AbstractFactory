using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de SQL Connection foi chamado...");
        }
    }
}
