using System;
using System.Collections.Generic;
using System.Text;

namespace customer_app
{
    public class Controller:ISubject
    {
        public List<Customer> AllCustomers = new List<Customer>();
        public List<IObserver> MyObservers = new List<IObserver>();

        public void AttachObserver(IObserver obs)
        {
            MyObservers.Add(obs);
        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in MyObservers)
            {
                obs.Update();
            }
        }

        public void CreateCustomer(string firstName, string lastName, bool isBankStaff)
        {
            // add new customer to all customers list, set first and last name of customer
            AllCustomers.Add(new Customer(firstName, lastName, isBankStaff));
            NotifyObservers();
        }

        public void DeleteCustomer(int deleteID)
        {
            // remove customer from list where id matches delete id
            AllCustomers.RemoveAll(c => c.ID == deleteID);
            NotifyObservers();
        }

        public void EditCustomer(int iD, string newFirstName, string newLastName, bool newIsBankStaff)
        {
            // get customer index in list by index
            int index = AllCustomers.FindIndex(c => c.ID == iD);
            // update with new (or same, old) first name
            AllCustomers[index].FirstName = newFirstName;
            // update with new (or same, old) last name
            AllCustomers[index].LastName = newLastName;
            // update isBankStaff value
            AllCustomers[index].IsBankStaff = newIsBankStaff;

            NotifyObservers();
        }
    }
}
