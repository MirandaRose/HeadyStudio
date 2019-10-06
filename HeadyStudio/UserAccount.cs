using System;
using System.Collections.Generic;
using System.Text;

namespace HeadyStudio
{ 
    {
    enum ClearRodSizes
    {
        ClearRod4mm,
        ClearRod6mm,
        ClearRod7mm
    }

    enum ClearTubingSizes
    {
        TubeMedium12mm,
        TubeMedium9mm,
        TubeMedium25mm
    }

    enum ColoredRodsColors
    {
        AquaAzul,
        OGMoss,
        BlueSatin,
        PurpleLollipop
    }
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
        /// Sizes of clear rod
        /// </summary>
        public ClearRodSizes ClearRods { get; set; }
        /// <summary>
        /// Sizes of clear tubing
        /// </summary>
        public ClearTubingSizes ClearTubing { get; set; }
        /// <summary>
        /// Colored rods
        /// </summary>
        public ColoredRodsColors ColoredRods { get; set; }
        #endregion

        #region Contructor
        public UserAccount()
        {
            AccountNumber = ++LastUserAccountNumber;
            DateCreated = DateTime.Now;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Enter quantity of 4mm Clear Rod into the studio
        /// </summary>
        /// <param name="amount">Quantity of 3mm Clear Rod</param>
        public void Deposit4mm(int amount)
        {
            enum ClearRodSizes.ClearRod4mm += amount;
        }

    /// <summary>
    /// Enter quantity of 14mm Clear Rod into the studio
    /// </summary>
    /// <param name="amount">Quantity of 14mm Clear Rod</param>
    public void ClearRod14mm(int amount)
    {
        ClearRodSizes. += ClearRodamount;
    }

    /// <summary>
    /// Enter quantity of AquaAzul Rod into the studio
    /// </summary>
    /// <param name="amount">Quantity of AquaAzul Rod</param>
    public void DepositAqua(int amount)
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
}
    #endregion
}
}
