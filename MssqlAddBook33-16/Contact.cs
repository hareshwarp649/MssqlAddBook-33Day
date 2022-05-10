using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MssqlAddBook33_16
{
    internal class Contacts
    {
        #region Contacts Fields
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
        public double phoneNo { get; set; }
        public string email { get; set; }
        #endregion

        #region Adding Contacts from Console & returning Object
        public static Contacts AddContacts()
        {
            Contacts contacts = new Contacts();
            Console.Write("Enter First Name: ");
            contacts.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            contacts.lastName = Console.ReadLine();
            Console.Write("Enter the address: ");
            contacts.address = Console.ReadLine();
            Console.Write("Enter city Name: ");
            contacts.city = Console.ReadLine();
            Console.Write("Enter state Name: ");
            contacts.state = Console.ReadLine();
            Console.Write("Enter the zip Code: ");
            contacts.zipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the phone Number: ");
            contacts.phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the email Id: ");
            contacts.email = Console.ReadLine();
            return contacts;
        }
        #endregion
        public override string ToString()
        {
            return $"firstName : {this.firstName}\nlastName : {this.lastName}\naddress : {this.address}\ncity : {this.city}\nstate : {this.state}\nzipCode : {this.zipCode}\nphoneNo : {this.phoneNo}\nemail : {this.email}";
        }
    }
}

