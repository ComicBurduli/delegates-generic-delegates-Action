using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo
{
    public class Account
    {
        public NotificationDelegate notificationDelegate;
        public decimal Balance { get; set; }
        public Account(decimal balance)
        {
            this.Balance = balance;
        }

        public void FillBalance(decimal balance)
        {
            this.Balance += balance;
            notificationDelegate($"Your Balance increased by {balance} GEL and your current balance is: {this.Balance} GEL");
        }

        public void Withraw(decimal balance)
        {
            if(this.Balance >= balance)
            {
                this.Balance -= balance;
                notificationDelegate($"You withrawed {balance} GEL and your current balance is: {this.Balance} GEL");
            }

            else
                notificationDelegate($"Not enough balance");
        }

        //public void SetNotificationDelegate(NotificationDelegate _notificationDelegate)
        //{
        //    notificationDelegate += _notificationDelegate;
        //}

    }
}
