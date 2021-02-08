using System;
using System.Collections.Generic;
using System.Text;

namespace customer_app
{
    /// <summary>
    /// The controller method for the program. THis handles all main functionality of the program.
    /// </summary>
    public class Controller:ISubject
    {
        public List<Customer> AllCustomers = new List<Customer>();
        public List<IObserver> MyObservers = new List<IObserver>();

        /// <summary>
        /// Attaches an observer that listens for updates from NotifyObservers
        /// </summary>
        /// <param name="obs">The observer object being attached</param>
        public void AttachObserver(IObserver obs)
        {
            MyObservers.Add(obs);
        }

        /// <summary>
        /// Called when there is an update that should notify other components of the program
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver obs in MyObservers)
            {
                obs.Update();
            }
        }

        /// <summary>
        /// Create a new customer and set their details
        /// </summary>
        /// <param name="firstName">The first name of the new customer</param>
        /// <param name="lastName">The last name of the new customer</param>
        /// <param name="isBankStaff">If the new customer is a bank staff member</param>
        public void CreateCustomer(string firstName, string lastName, bool isBankStaff)
        {
            // add new customer to all customers list, set first and last name of customer
            AllCustomers.Add(new Customer(firstName, lastName, isBankStaff));
            NotifyObservers();
        }

        /// <summary>
        /// Delete an existing customer
        /// </summary>
        /// <param name="deleteID">The id of the customer being deleted</param>
        public void DeleteCustomer(int deleteID)
        {
            // remove customer from list where id matches delete id
            AllCustomers.RemoveAll(c => c.ID == deleteID);
            NotifyObservers();
        }

        /// <summary>
        /// Edit an existing customers details
        /// </summary>
        /// <param name="iD">The customers ID</param>
        /// <param name="newFirstName">The customers updated first name</param>
        /// <param name="newLastName">The customers updated last name</param>
        /// <param name="newIsBankStaff">If the customer is a bank staff member</param>
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

        /// <summary>
        /// Create a new account for a and set the opening balance and possible overdraft limit
        /// </summary>
        /// <param name="cust">The customer creating the account</param>
        /// <param name="accountType">The type of account being created</param>
        /// <param name="openingBalance">The opening balance of the account</param>
        /// <param name="overdraftLimit">The overdraft limit of the account, if omni account type</param>
        public void CreateAccount(
            Customer cust,
            string accountType,
            decimal openingBalance,
            decimal overdraftLimit)
        {
            // in this application, fail fee and interest rates are fixed
            decimal failFee = 10;
            decimal interestRate = (decimal).04;

            // get account type
            if (accountType == "everyday")
            {
                Account newAccount = new Everyday(openingBalance);
                AddAccountToCustomer(cust, newAccount);
            } else if (accountType == "investment")
            {
                Account newAccount = new Investment(openingBalance, interestRate, failFee);
                AddAccountToCustomer(cust, newAccount);
            } else if (accountType == "omni")
            {
                Account newAccount = new Omni(openingBalance, interestRate, failFee, overdraftLimit);
                AddAccountToCustomer(cust, newAccount);
            }
            
            NotifyObservers();
        }

        /// <summary>
        /// Add an account object to an existing customer object
        /// </summary>
        /// <param name="cust">The customer the account is being added to</param>
        /// <param name="acc">The account being added to the customer</param>
        public void AddAccountToCustomer(Customer cust, Account acc)
        {
            cust.Accounts.Add(acc);
            NotifyObservers();
        }

        /// <summary>
        /// Deposit money from an account
        /// </summary>
        /// <param name="acc">The account being deposited from</param>
        /// <param name="amount">The amount being deposited</param>
        public void MakeDeposit(Account acc, decimal amount)
        {
            acc.Deposit(amount);
            NotifyObservers();
        }

        /// <summary>
        /// Withdraw money from an account
        /// </summary>
        /// <param name="acc">The account being withdrawn from</param>
        /// <param name="amount">The amount being withdrawn</param>
        public void MakeWithdrawal(Account acc, decimal amount)
        {
            acc.Withdraw(amount);
            NotifyObservers();
        }

        /// <summary>
        /// Transfer money from one account to another
        /// </summary>
        /// <param name="accFrom">The "from" account for the transaction</param>
        /// <param name="accTo">The "to" account for the transaction</param>
        /// <param name="amount">The amount being transferred</param>
        /// <returns></returns>
        public string MakeTransfer(Account accFrom, Account accTo, decimal amount)
        {
            // if withdrawal is successful
            try
            {
                accFrom.Withdraw(amount);
                // then deposit in to receiving account
                accTo.Deposit(amount);
                string output = "Transfer successful!";
                NotifyObservers();
                return output;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                NotifyObservers();
                return errorMessage;
            }
        }

        /// <summary>
        /// Calculate interest for an account
        /// </summary>
        /// <param name="acc">The account being acted on</param>
        public void AddInterest(Account acc)
        {
            acc.GetInterest();
            NotifyObservers();
        }
    }
}
