// Thomas Lauer
// MavPASS 20210914

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_20210914
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            // Thomas
            Customer myCustomer1 = new Customer(
                "TheID",
                "Joe Shmoe III",
                "3005884300",
                "Washington DC, Florida",
                "FamilyPlan",
                new List<string>() { "Name1" },
                new List<string>() { "PhoneNumber1", "PhoneNumber2" }
                );

            // Madelyn
            Customer myCustomer2 = new Customer(
                "55,444,555,555,0,6,33,0,66,666,9",
                "Ham Stu",
                "800-273-8255",
                "420 Punk Ave, Denver Oregon",
                "Single Plan",
                new List<string>() { },
                new List<string>() { }
                );

            // Kidus
            Customer myCustomer3 = new Customer(
                "The id",
                "Kidus Alex",
                "240-476-9786",
                "Mankato MN",
                "Life plan",
                new List<string>() { "Kidus", "Geni", "Wengel", "Alex" },
                new List<string>() { "244", "655" }
                );

            // Nathaniel
            Customer myCustomer4 = new Customer(
                "4815162342",
                "Donald Biden",
                "651-488-8888",
                "666 Emo Ave, LA Florida", 
                "Family Plan",
                new List<string>(){"Obama","Joe","Washington","Lincoln"},
                new List<string>(){"911","411","N/A","311"}
            );

            //Simon

            Customer myCustomer5 = new Customer(
                "45656374",
                "Bob Smith",
                "098-776-5874",
                "557 Jude Ave, MD Baltimore",
                "Family Plan",
                new List<string>() { "simon", "kidus", "meri"},
                new List<string>() {"8897", "4455", "3232"}
                
            );      

            //Sungjae
            Customer myCustomer6 = new Customer(
                "00002351",
                "Sungjae Oh",
                "6123052235",
                "Atlanta, Georgia",
                "Super Premium Plan",
                new List<string>() {"Donald Oh"},
                new List<string>() {"7757790153"}
                
            );

            // ANSWER IS BELOW THIS LINE         

            myCustomer1.CheckValidity();
            myCustomer2.CheckValidity();
            myCustomer3.CheckValidity();
            myCustomer4.CheckValidity();
            myCustomer5.CheckValidity();
            myCustomer6.CheckValidity();

            customers.Add(myCustomer1);
            customers.Add(myCustomer2);
            customers.Add(myCustomer3);
            customers.Add(myCustomer4);
            customers.Add(myCustomer5);
            customers.Add(myCustomer6);

            
            // ANSWER IS ABOVE THIS LINE


            // waste of computation time


            

            foreach(Customer c in customers)
            {
               Console.WriteLine(c.ToString()+"\n");
                
                

            }

            Console.ReadLine();
        }
    }
}
