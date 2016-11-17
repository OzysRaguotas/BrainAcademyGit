using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForUTEC
{
    class JSOperations
    {
        public void MyDeserialization()
        {
            var json = File.ReadAllText(@"C:\Users\Слава\Desktop\Request1.txt");
            List<Request> requests= JsonConvert.DeserializeObject<List<Request>>(json);
            var selectedRequests = from r in requests
                                   where r.Manager.Head_User == "RQ-24390"
                                   select r;
            foreach (Request r in selectedRequests)
            {
                Console.WriteLine("Status: " + r.Status);
                Console.WriteLine("Department: " + r.Department);
                Console.WriteLine("E-mail: " + r.Email);
                Console.WriteLine("Description: " + r.Description);
                Console.WriteLine("Phones: " + r.Phones);
                Console.WriteLine("Manager.Head_User: " + r.Head_user);
                Console.WriteLine("Manager: " + r.Manager);
                Console.WriteLine("Code: " + r.Code);
                Console.WriteLine("Added Time: " + r.Added_Time);
                Console.WriteLine("_____________");
            }

            //var data = JsonConvert.DeserializeObject<List<Request>>(json);
            //var sb = new StringBuilder();

            //First iteration
            //data.ForEach(Request =>
            //{
            //    sb.AppendFormat(@"Status: {0} Department: {1} Email: {2} Description: {3} Phones: {4} Manager: {5}, Code: {6}, Added Time: {7}{8}", Request.Status, Request.Department, Request.Email, Request.Description, Request.Phones, Request.Manager, Request.Code, Request.Added_Time, Environment.NewLine);
            //});

            //Second iteration
            //Console.WriteLine(sb.ToString());
            //var tbl = JArray.Parse(json)
            //        .Select(j => new
            //        {
            //            Status = j["Status"],
            //            Department = j["Department"],
            //            Email = j["Email"],
            //            Description = j["Description"],
            //            Phones = j["Phones"],
            //            Head_user= j["Manager.Head_user"],
            //            Manager = j["Manager"],
            //            Code = j["Code"],
            //            Added_Time = j["Added_Time"]

            //        });
            //foreach (var r in tbl.Where(r => r.Head_user("Skrypnik Yuriy")))
            //{
            //    Console.WriteLine("Status: "+ r.Status);
            //    Console.WriteLine("Department: "+r.Department);
            //    Console.WriteLine("E-mail: " + r.Email);
            //    Console.WriteLine("Description: " + r.Description);
            //    Console.WriteLine("Phones: " + r.Phones);
            //    Console.WriteLine("Manager.Head_User: "+ r.Head_user);
            //    Console.WriteLine("Manager: " + r.Manager);
            //    Console.WriteLine("Code: " + r.Code);
            //    Console.WriteLine("Added Time: " + r.Added_Time);
            //    Console.WriteLine("_____________");
            //}

        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            JSOperations MyJSOperations = new JSOperations();
            MyJSOperations.MyDeserialization();
            Console.ReadLine();
        }
    }
}
