﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;
using Borromeo_Filomeno_FinalProject.Properties;

namespace Borromeo_Filomeno_FinalProject
{
    public class clsFile
    {

        private const string filePath = @"C:\Users\ACT-STUDENT\Desktop\FinalProj\Borromeo_Filomeno_FinalProject\File\Accounts.txt";

        private const string filePathForm = @"C:\Users\ACT-STUDENT\Desktop\FinalProj\Borromeo_Filomeno_FinalProject\File\AccountForm.txt";

        //Returns the accounts from the file
        public List<clsAccount> GetAccountsinFile()
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

        

        public void ImportAccountToForm(string username)
        {
            string[] output = { username };

            File.WriteAllLines(filePathForm, output);
        }

        public string GetAccountFromForm()
        {
            List<string> lines = File.ReadAllLines(filePathForm).ToList();
            string account = string.Empty;
            //Searches for the account then returns as string
            foreach(var line in lines)
            {
                account = line;
            }
            //Clears the txt file so that it will always have a unique entry

            return account;

        }

        //Overwrites the textfile to empty
        public void RemoveText()
        {
            File.WriteAllText(filePathForm, string.Empty);
        }


        //Import Account to the file
        public void ImportAccountsToFile(List<clsAccount> accounts)
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

            //Checking if the account username is in the file
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
                    
                    strSplit[3] = score.ToString();
                    
                    output.Add($"{strSplit[0]},{strSplit[1]},{strSplit[2]},{strSplit[3]}");

                }
                else
                {
                    output.Add($"{strSplit[0]},{strSplit[1]},{strSplit[2]},{strSplit[3]}");

                }


            }
            File.WriteAllLines(filePath, output);
        }


    }
}
