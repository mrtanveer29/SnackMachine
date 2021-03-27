using Domain.Logic;
using System;

namespace Domain
{
    public sealed class SnackMachine
    {

        public Money MoneyInside { get; private set; }
        public Money MoneyInTransaction { get; private set; }

        public void InsertMoney(Money moneyInserted)
        {
            MoneyInTransaction += moneyInserted;
        }

        public void ReturnMoney()
        {
           //MoneyInTransaction=0;
        }

        public void BuyFood()
        {
            MoneyInside += MoneyInTransaction;
            //MoneyInTransaction = 0;
        }

    }
}
