using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MssqlAddBook33_16
{
    internal class AdBooks
    {

        #region List for adding Contacts
        public List<Contacts> listOfContacts = new List<Contacts>();
        #endregion

        #region Adding Contact Details in List & returning the list
        public List<Contacts> AddContactDetailsInList(Contacts C1)
        {
            CheckForDuplicates(listOfContacts, C1);
            return listOfContacts;
        }
        #endregion

        #region Editing the Existing Contacts
        public void EditContacts()
        {
            Console.WriteLine("Enter the name of the person whose contact details you want to edit: ");
            string nameOfEditingContactPerson = Console.ReadLine().ToUpper();
            Contacts editedContact = null;
            foreach (Contacts contact in listOfContacts)
            {
                if (contact.firstName.ToUpper() == nameOfEditingContactPerson)
                {
                    editedContact = contact;
                    Console.WriteLine("Enter the option to modify the property: ");
                    Console.WriteLine("Enter 1 to Change First name ");
                    Console.WriteLine("Enter 2 to Change Last name ");
                    Console.WriteLine("Enter 3 to Change Phone Number ");
                    Console.WriteLine("Enter 4 to Change Address ");
                    Console.WriteLine("Enter 5 to Change City ");
                    Console.WriteLine("Enter 6 to Change State ");
                    Console.WriteLine("Enter 7 to Change Pincode ");
                    Console.WriteLine("Enter 8 to Chnage Email ");
                    Console.WriteLine("Enter 9 to Exit ");
                    int Check = Convert.ToInt32(Console.ReadLine());
                    switch (Check)
                    {
                        case 1:
                            Console.WriteLine("Enter the New First Name: ");
                            editedContact.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the New Last Name: ");
                            editedContact.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the New Phone Number: ");
                            editedContact.phoneNo = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter the New Address: ");
                            editedContact.address = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the New City: ");
                            editedContact.city = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the New State: ");
                            editedContact.state = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter the New Zip Code: ");
                            editedContact.zipCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter the New email: ");
                            editedContact.email = (Console.ReadLine());
                            break;
                        case 9:
                            return;
                    }
                }
            }
        }
        #endregion

        #region Preventing Addition of Duplicates by verifying names
        private void CheckForDuplicates(List<Contacts> listOfContacts, Contacts C1)
        {
            bool isEmpty = !listOfContacts.Any();
            if (isEmpty)
            {
                listOfContacts.Add(C1);
            }
            else
            {
                foreach (Contacts c in listOfContacts)
                {
                    if (!(c.firstName == C1.firstName))
                    {
                        listOfContacts.Add(C1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{C1.firstName} already exists");
                    }
                }
            }
        }
        #endregion

        #region Displaying Contact Details after Adding into List
        public void DisplayContactsDetails()
        {
            Console.WriteLine("Details of the Contacts are: ");
            foreach (Contacts contact in listOfContacts)
            {
                Console.WriteLine($"Full Name: {contact.firstName} {contact.lastName}\nAddress is: {contact.address}\nCity Name is: {contact.city}\nState Name is: {contact.state}\nZipCode is: {contact.zipCode}\nPhone Number is: {contact.phoneNo}\nEmail is: {contact.email} ");
                Console.WriteLine("--------------------------------------------------");
            }
        }
        #endregion

        #region For removing the contacts from list
        public void DeleteContacts()
        {
            Console.WriteLine("Enter the name of the person whose contact details you want to delete: ");
            string nameOfDeletingContactPerson = Console.ReadLine().ToUpper();
            Contacts deletedContact = null;
            foreach (Contacts contact in listOfContacts)
            {
                if (contact.firstName.ToUpper() == nameOfDeletingContactPerson)
                {
                    deletedContact = contact;
                }
            }
            if (deletedContact != null)
            {
                listOfContacts.Remove(deletedContact);
            }
        }
        #endregion
    }
}
