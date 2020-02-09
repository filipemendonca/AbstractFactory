using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maniera errada

            /*var con = new SqlConnection();
            con.Open();

            var cmd = new SqlCommand();
            cmd.Execute();

            Console.ReadLine();*/

            //Maneira correta de acordo com o abstract factory
            /* Aqui vamos estanciar a nossa Factory */

            // Com Sql
            DbFactory db = new SqlFactory();            

            var con = db.CreateConnection();
            con.Open();

            var cmd = db.CreateCommand();
            cmd.Execute();          

            Console.ReadLine();

        }
    }
}
