using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo
{
    public delegate void NotificationDelegate(string message);
    public class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(1_000.59m);
            //myAccount.SetNotificationDelegate(DisplayInConsole);
            //myAccount.SetNotificationDelegate(WriteDataToStore);
            myAccount.notificationDelegate += DisplayInConsole; // subscribing
            myAccount.notificationDelegate += WriteDataToStore; 

            myAccount.notificationDelegate -= DisplayInConsole;// unsubscribing


            myAccount.FillBalance(400m);
            myAccount.Withraw(800m);
            myAccount.Withraw(8_000m);

            Console.ReadKey();
        }

        static void DisplayInConsole(string msg)
        {
            Console.WriteLine(msg); 
        }

        static void WriteDataToStore(string data)
        {
            string path = "D:\\ASUS Data\\IT Step Lecture Course\\2024_GR39_4\\C#\\Lecture 22. Delegates\\DelegatesDemo\\data.txt";
            string path2 = @"D:\ASUS Data\IT Step Lecture Course\2024_GR39_4\C#\Lecture 22. Delegates\DelegatesDemo";

            File.AppendAllText(path, data);
        }
    }
}
