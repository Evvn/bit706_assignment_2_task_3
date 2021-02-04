using System;
using System.Collections.Generic;
using System.Text;

namespace customer_app
{
    public class Customer
    {
        private static int nextID = 1;
        private int iD;
        private string firstName;
        private string lastName;
        private bool isBankStaff;

        public Customer() // default constructor
        {
            iD = nextID;
            isBankStaff = false; // default to false in case not specified
            nextID++;
        }

        public Customer(string setFirstName, string setLastName, bool setIsBankStaff) : this()  // with params
        {
            firstName = setFirstName;
            lastName = setLastName;
            isBankStaff = setIsBankStaff;
        }

        public int ID { get => iD; }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public bool IsBankStaff { get => isBankStaff; set => isBankStaff = value; }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
