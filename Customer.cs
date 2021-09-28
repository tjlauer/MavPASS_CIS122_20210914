// Thomas Lauer
// MavPASS 20210914

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_20210914
{
    public class Customer
    {
        //* Variables
        private string customerID = "n/a";
        private string name = "n/a";
        private string phoneNumber = "n/a";
        private string address = "n/a";
        private string plan = "n/a";
        private List<string> members = new List<string>();
        private List<string> memberNumbers = new List<string>();
        //*/

        //* Properties
        public string CustomerID {
            get { return this.customerID; }
            set {
                this.customerID = value;
            }
        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public string Plan { get { return this.plan; } set { this.plan = value; } }
        public List<string> Members { get { return this.members; } set { this.members = value; } }
        public List<string> MemberNumbers { get { return this.memberNumbers; } set { this.memberNumbers = value; } }

        
        //*/

        // Constructors
        public Customer() { /* empty */ }

        public Customer(string aCustomerID, string aName, string aPhoneNumber, string anAddress, string aPlan, List<string> aMembers, List<string> aMemberNumbers)
        {
            this.CustomerID = aCustomerID;
            this.Name = aName;
            this.PhoneNumber = aPhoneNumber;
            this.Address = anAddress;
            this.Plan = aPlan;
            this.Members = aMembers;
            this.MemberNumbers = aMemberNumbers;
        }

        // Methods
        public void CheckValidity()
        {
            if (Members.Count > MemberNumbers.Count)
            {
                int difference = Members.Count - MemberNumbers.Count;
                string unknown = "n/a";

                for(int i=0; i < difference ;i++)
                {
                    MemberNumbers.Add(unknown);
                }


            }
            else if(MemberNumbers.Count > Members.Count)
            {
                int difference = MemberNumbers.Count - Members.Count;
                string unknown = "n/a";

                for (int i=0; i < difference ;i++)
                {
                    Members.Add(unknown);
                }

            }
        }


        public override string ToString()
        {
            string msg = "";
            msg += "CustomerID: " + this.CustomerID + "\n";
            msg += "Name: " + this.Name + "\n";
            msg += "PhoneNumber: " + this.PhoneNumber + "\n";
            msg += "Address: " + this.Address + "\n";
            msg += "Plan: " + this.Plan + "\n";
            msg += "Members:\n";
            foreach(string member in this.Members) { msg += "\t" + member + "\n"; }
            msg += "MemberNumbers:\n";
            foreach (string memberNumber in this.MemberNumbers) { msg += "\t" + memberNumber + "\n"; }
            return msg;
        }
    }
}
