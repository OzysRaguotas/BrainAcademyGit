using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2_Events
{
    class CustomerInformation
    {// field for users information
        string ciName;
        string ciFamily;
        int ciID;

        // Constructor
        public CustomerInformation(string Name, string Family, int ID)
        {
            this.Name = Name;
            this.Family = Family;
            this.ID = ID;
        }
        // Properties
        public string Name { set { ciName = value; } get { return ciName; } }
        public string Family { set { ciFamily = value; } get { return ciFamily; } }
        public int ID { set { ciID = value; } get { return ciID; } }

        //event-drive handler
        public void CIHandler()
        {
            Console.WriteLine(" iPhone I7 is now available!!!");
            Console.WriteLine("Name: {0}, Family: {1}, ID: {2}", Name, Family, ID);
        }
    }
}
