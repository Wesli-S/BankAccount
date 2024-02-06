//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single customers bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Creates an account with a specific owner and a balance of 0
        /// </summary>
        /// <param name="accOwner">Full name of the customer who owns the account</param>
        public Account(string accOwner)
        {
            Owner = accOwner;
        }
        /// <summary>
        /// Full name od the owner of the account 
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// How much money is currently in the account
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Add a specified amount of money to the account
        /// </summary>
        /// <param name="amt">positive amount to deposit</param>
        /// <returns>The new balance after the deposit</returns>
        public double Deposit(double amt)
        {
            if(amt <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(amt)}Please enter an amount greater than 0");
            }
            Balance += amt;
            return Balance;

        }
        /// <summary>
        /// Take a specific amount of money from the account
        /// </summary>
        /// <param name="amt">Positive amount to withdraw</param>
        public double Withdraw(double amt)
        {
            if(amt > Balance) 
            {
                throw new ArgumentException($"{nameof(amt)} cannot be greater than {nameof(Balance)}");
            }
            if(amt <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(amt)} must be greater than 0");
            }
            Balance -= amt;
            return Balance;
        }


    }
}
