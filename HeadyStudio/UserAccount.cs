using System;
using System.Collections.Generic;
using System.Text;

namespace HeadyStudio
{
    class UserAccount
    {
        private static int LastUserAccountNumber = 0;

        #region UserAccountProperties
        /// <summary>
        /// Email address of the user account
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Autogenrated number of the user account
        /// </summary>
        public int AccountNumber { get; }
        /// <summary>
        /// Date the user created account
        /// </summary>
        public DateTime DateCreated { get; }
        /// <summary>
        /// Quantity of 3mm clear rods
        /// </summary>
        public int ClearRod3mm { get; set; }
        /// <summary>
        /// Quantity of 14mm clear rods
        /// </summary>

        public int ClearRod14mm { get; set; }
        /// <summary>
        /// Quantity of AquaAzul rods
        /// </summary>
        public int AquaAzulRod { get; set; }
        #endregion

        #region Contrustor
        public UserAccount()
        {
            AccountNumber = ++LastUserAccountNumber;
            DateCreated = DateTime.Now;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Enter quantity of 3mm Clear Rod into the studio
        /// </summary>
        /// <param name="amount">Quantity of 3mm Clear Rod</param>
        public void Deposit3mm (int amount)
        {
            ClearRod3mm +=amount;
        }

        /// <summary>
        /// Enter quantity of 14mm Clear Rod into the studio
        /// </summary>
        /// <param name="amount">Quantity of 14mm Clear Rod</param>
        public void Deposit14mm (int amount)
        {
            ClearRod14mm += amount;
        }

        /// <summary>
        /// Enter quantity of AquaAzul Rod into the studio
        /// </summary>
        /// <param name="amount">Quantity of AquaAzul Rod</param>
        public void DepositAqua (int amount)
        {
            AquaAzulRod += amount;
        }

        /// <summary>
        /// Enter quantity of 3mm Clear Rod used in the studio
        /// </summary>
        /// <param name="amount">Quantity of 3mm Rod used</param>
        public void Withdrawl3mm(int amount)
        {
            ClearRod3mm -= amount;
        }

        /// <summary>
        /// Enter quantity of 14mm Clear Rod used in the studio
        /// </summary>
        /// <param name="amount">Quantity of 14mm Rod used</param>
        public void Withdrawl4mm(int amount)
        {
            ClearRod14mm -= amount;
        }

        /// <summary>
        /// Enter quantity of AquaAuzl Rod used in the studio
        /// </summary>
        /// <param name="amount">Quantity of AquaAzul Rod used</param>
        public void WithdrawlAqua(int amount)
        {
            AquaAzulRod -= amount;
        }
        #endregion
    }
}
