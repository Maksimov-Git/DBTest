using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;
using System.Data;
using System.Xml.Schema;

namespace Less_DB_2
{
   
    class Program
    {
        

        static void Main(string[] args)
        {
            SqlConnection Connection;
            SqlDataReader Reader;


            Connection = new SqlConnection("Data Source = tcp:tsopp.database.windows.net; Initial Catalog = TSOPPTEST; Persist Security Info = True; User ID = tsoppadmin; Password = Geirby1799");

            Connection.Open();

           // string SQLQ = "CREATE TABLE [SalesLT].[tAuthors] ( AuthorId INT IDENTITY(1, 1) NOT NULL, AuthorFirstName NVARCHAR(20) " +
            //    "NOT NULL, AuthorLastName       NVARCHAR(20)    NOT NULL, AuthorAge            INT NOT NULL); ";



            //  string SQLQ = "SELECT * FROM [SalesLT].[Address]"; //  запросить все строки и столбцы таблицы

            //string SQLQ = "SELECT count(*) FROM [SalesLT].[Customer]"; // информация о количестве записей

            //string SQLQ = "SELECT TOP 200 [EmailAddress], [FirstName]  FROM [SalesLT].[Customer] ORDER BY [SalesPerson]";


            //string SQLQ = "SELECT* FROM[SalesLT].[ProductDescription]";//

          //  string SQLQ = "INSERT [SalesLT].[ProductDescription] ('31231222', 'no' ,'301EED3A-1A82-4855-99CB-2AFE8290D641','2007-06-01 00:00:00.000'";

            SqlCommand Comand = new SqlCommand(SQLQ, Connection);

            SqlDataReader reader = Comand.ExecuteReader();
            DataTable Tab = reader.GetSchemaTable();

            while (reader.Read())
            {

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i].ToString());
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            reader.Close();

            Connection.Close();
            Console.ReadKey();
        }
    }
}
