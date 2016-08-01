using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace ADO_dot_NET_Lab
{
    class dbOperations
    {
        public static void AddInfo()
        {
            string connectionString = @"Data Source=DESKTOP-47FAHAR\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Console.WriteLine("Enter students name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter group");
            var group = Console.ReadLine();
            Console.WriteLine("Enter students ID number");
            var StudID = Console.ReadLine();
            Console.WriteLine("Enter average grade");
            var AvR = Console.ReadLine();

            string sqlExpression = $"INSERT INTO Students ([Name], [Group], [StudID], [AvgRate]) VALUES ('{name}', '{group}', '{StudID}', '{AvR}')";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(sqlExpression, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Insert has being successfull");
        }
        public static void ShowInfo()
        {
            string connectionString = @"Data Source=DESKTOP-47FAHAR\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //create connection
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Open connection");
                var adapter = new SqlDataAdapter("SELECT * FROM Students", connectionString);
                var data = new DataSet();
                adapter.Fill(data);
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    var id = (int)row[0];
                    var name = (string)row[1];
                    var group = (string)row[2];
                    var IdNumb = (string)row[3];
                    var avRate = (double)row[4];
                    Console.WriteLine($"{id}, {name}, {group}, {IdNumb}, {avRate}");

                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            //close connection
            {
                connection.Close();
                Console.WriteLine("Connection close");
            }
        }
        public static void EditInfo()
        {
            string connectionString = @"Data Source=DESKTOP-47FAHAR\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Console.WriteLine("Edit students information by Name or ID ");
            Console.WriteLine("For Name editing enter 1, for ID - enter 2");
            var chose = int.Parse(Console.ReadLine());
            if (chose == 1)
            {
                Console.WriteLine("Insert student Name");
                var name = Console.ReadLine();
                Console.WriteLine(@"Insert update target(format: ""Name = 'Ivan Ivanov'"")");
                var target = Console.ReadLine();

                var query = $"UPDATE Students SET {target} WHERE ID = {name}";
                Console.WriteLine(query);
                //create connection
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else if (chose == 2)
            {
                Console.WriteLine("Insert students ID");
                    var id = Console.ReadLine();
                    Console.WriteLine(@"Insert update target(format: ""Group = EM-21 or [Average grade] = 5.0 "")");
                    var target = Console.ReadLine();

                    var query = $"UPDATE Students SET {target} WHERE ID = {id}";
                    Console.WriteLine(query);

                    using (var connection = new SqlConnection(connectionString))
                    {
                        using (var command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    } 
            }
            Console.WriteLine("Update was successfull");
        }
       
        public static void RemoveInfo()
        {
            string connectionString = @"Data Source=DESKTOP-47FAHAR\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Console.WriteLine("DELETE student by ID or by Name");
            Console.WriteLine("Bottom 1 for ID, Bottom 2 for Name");
            var choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Insert student ID");
                var id = int.Parse(Console.ReadLine());
                var query = $"DELETE FROM Students WHERE ID = {id}";
                Console.WriteLine(query);
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Delete was successfull");
            }

            else if (choose == 2)
            {
                Console.WriteLine("Insert student Name");
                var name = Console.ReadLine();
                var query = $"DELETE FROM Students WHERE Name = '{name}'";
                Console.WriteLine(query);
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Delete was successfull");
            }
        }}
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You work with Students-database");
            Console.WriteLine("Use next bottoms for action:");
            Console.WriteLine("1 - Add information for one student");
            Console.WriteLine("2 - Show students' list"); 
            Console.WriteLine("3 - Edit information by student's Name or student's ID");
            Console.WriteLine("4 - Remove information about chosen student by student's Name or Students ID");
            Console.WriteLine("5 - Escape from the program");

            bool progrWork = true;
            while (progrWork == true)
            {
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        { dbOperations.AddInfo(); }
                        break;
                    case 2:
                        { dbOperations.ShowInfo(); }
                        break; 
                    case 3:
                        { dbOperations.EditInfo(); }
                        break;
                    case 4:
                        { dbOperations.RemoveInfo(); }
                        break;
                    case 5:
                        { progrWork = true; }
                        break;
                } 
            }
        }
    }
}

