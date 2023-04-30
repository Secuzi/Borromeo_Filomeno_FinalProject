using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;

namespace Borromeo_Filomeno_FinalProject
{
    internal class clsDatabase
    {
        private const string filePath = @"D:\Harold Sheesh\Desktop\Borromeo_Filomeno_FinalProject\Borromeo_Filomeno_FinalProject\Database\Accounts.txt";

        //public string GetAccountsInDatabase
        //{
        //    get { return filePath; }
        //}



        //Returns the accounts from the database
        public List<clsAccount> GetAccountsInDatabase()
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<clsAccount> accountsList = new List<clsAccount>();

            foreach(string line in lines)
            {
                string[] entries = line.Split(',');
                if (entries.Length == 4)
                {
                    clsAccount account = new clsAccount();

                    account.Username = entries[0];
                    account.Password = entries[1];
                    account.Email = entries[2];
                    account.Balance = decimal.Parse(entries[3]);

                    accountsList.Add(account);
                }
                else
                {
                    MessageBox.Show("Index out of bounds");
                }
                
            }

            return accountsList;
            
        }

        //Import Account to the database
        public void ImportAccountsToDatabase(List<clsAccount> accounts)
        {
            List<string> output = new List<string>();

            foreach(var account in accounts)
            {

                output.Add($"{account.Username},{account.Password},{account.Email},{account.Balance}");
            }

            File.WriteAllLines(filePath, output);

        }

        public void BalanceChanges(string username, decimal balance, List<clsAccount> accounts)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> output = new List<string>();
           
            clsAccount account = null;
            foreach (var line in lines)
            {
                string[] strSplit = line.Split(',');


                //clsAccount clsUsername = accounts.Find(a => a.Username == username);

                if (strSplit[0] == username)
                {
                    account = accounts.Find(user => user.Username == username);

                    account.Balance = balance;
                    output.Add($"{account.Username},{account.Password},{account.Email},{account.Balance}");

                }
                else
                {
                    account = accounts.Find(user => user.Username != username);
                    output.Add($"{account.Username},{account.Password},{account.Email},{account.Balance}");

                }


            }
            File.WriteAllLines(filePath, output);
        }


    }
}
