using System;

namespace Domain
{
    public sealed class SnackMachine
    {
        public int OneCentCount { get; private set; }
        public int TenCentCount { get; private set; }
        public int QuarterCount { get; private set; }
        public int OneDollarCount { get; private set; }
        public int FiveDollarCount { get; private set; }
        public int TwentyDollarCount { get; private set; }

        public int OneCentInTransaction { get; private set; }
        public int TenCentInTransaction { get; private set; }
        public int QuarterInTransaction { get; private set; }
        public int OneDollarInTransaction { get; private set; }
        public int FiveDollarInTransaction { get; private set; }
        public int TwentyDollarInTransaction { get; private set; }

        public void InsertMoney(int oneCentCount,
                                int tenCentCount,
                                int quarterCount,
                                int oneDollarCount,
                                int tenDollarCount,
                                int twentyDollarCount)
        {
            OneCentInTransaction += oneCentCount;
            TenCentInTransaction += tenCentCount;
            QuarterInTransaction += quarterCount;
            OneDollarInTransaction += oneDollarCount;
            FiveDollarInTransaction += FiveDollarCount;
            TwentyDollarInTransaction += twentyDollarCount;
        }

        public void ReturnMoney()
        {
            OneCentInTransaction = 0;
            TenCentInTransaction = 0;
            QuarterInTransaction = 0;
            OneDollarInTransaction = 0;
            FiveDollarInTransaction = 0;
            TwentyDollarInTransaction = 0;
        }

        public void BuyFood()
        {
            OneCentCount += OneCentInTransaction;
            TenCentCount += TenCentInTransaction;
            QuarterCount += QuarterInTransaction;
            OneDollarCount += OneDollarInTransaction;
            FiveDollarCount += FiveDollarInTransaction;
            TwentyDollarCount += TwentyDollarInTransaction;

            OneCentInTransaction = 0;
            TenCentInTransaction = 0;
            QuarterInTransaction = 0;
            OneDollarInTransaction = 0;
            FiveDollarInTransaction = 0;
            TwentyDollarInTransaction = 0;
        }

    }
}
