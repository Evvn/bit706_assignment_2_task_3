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

        public Customer() // default constructor
        {
            iD = nextID;
            nextID++;
        }

        public Customer(string setFirstName, string setLastName) : this()  // with params
        {
            firstName = setFirstName;
            lastName = setLastName;
        }

        public int ID { get => iD; }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
