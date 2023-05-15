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
    public class clsDatabase
    {
        private const string filePath = @"D:\Harold Sheesh\Desktop\Please\Borromeo_Filomeno_FinalProject\Database\Accounts.txt";

        


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
                    account.Score = int.Parse(entries[3]);

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

                output.Add($"{account.Username},{account.Password},{account.Email},{account.Score}");
            }

            File.WriteAllLines(filePath, output);

        }

        public void ScoreChanges(string username, int score, List<clsAccount> accounts)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> output = new List<string>();
           
            clsAccount account = null;
            //Checking if the account username is in the database
            foreach (var line in lines)
            {
                string[] strSplit = line.Split(',');


                #region if things go bad
                /*
                 * if (strSplit[0] == username || strSplit[2] == username)
                {
                    account = accounts.Find(user => user.Username == username);

                    account.Score = score;
                    output.Add($"{account.Username},{account.Password},{account.Email},{account.Score}");

                }
                else
                {
                    account = accounts.Find(user => user.Username != username);
                    output.Add($"{account.Username},{account.Password},{account.Email},{account.Score}");

                }
                */
                #endregion



                //Checks if the input the user has entered is their mail or username.

                if (strSplit[0] == username || strSplit[2] == username)
                {
                    account = accounts.Find(user => user.Username == username);

                    account.Score = score;
                    output.Add($"{account.Username},{account.Password},{account.Email},{account.Score}");

                }
                else
                {
                    account = accounts.Find(user => user.Username != username);
                    output.Add($"{account.Username},{account.Password},{account.Email},{account.Score}");

                }


            }
            File.WriteAllLines(filePath, output);
        }


    }
}
