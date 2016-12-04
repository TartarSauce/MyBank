using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public enum typeOfAccount { Checking, Saving};
    /// <summary>
    /// This class describes a bank account
    /// </summary>
    class Account
    {
        #region Statics
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        public int AccountNumber {
            get;
            private set;
        }
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }
        public typeOfAccount AccountType { get; set; }
        #endregion

        #region Contructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }
        #endregion

        #region Methods
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            return Balance;
        }
        #endregion


    }
}