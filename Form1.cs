using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace PasswordManager
{
    public partial class Form1 : Form
    {
        #region Variables
        string[] Accounts = File.ReadAllLines(@"C:\Users\Public\Documents\Accounts.txt");
        string[] Accessibles = File.ReadAllLines(@"C:\Users\Public\Documents\Accessibles.txt");
        string[] Usernames = File.ReadAllLines(@"C:\Users\Public\Documents\Usernames.txt");
        #endregion

        public Form1()
        {
            InitializeComponent();
            LogBox.Visible = false;
            richTextBox1.Width = richTextBox1.Width + 180;
            //richTextBox1.AppendText("Which account would you like?\r\n"); richTextBox1.Focus();
            //inputText.();
            //StreamWriter Accountsfile = new StreamWriter(@"C:\Users\Public\Documents\Accounts.txt");
            //StreamWriter Accessiblesfile = new StreamWriter(@"C:\Users\Public\Documents\Accessibles.txt");
            //StreamWriter Usernamesfile = new StreamWriter(@"C:\Users\Public\Documents\Usernames.txt");
            //for(int i = 0; i<Accounts.Length; i++) { Accountsfile.WriteLine(Accounts[i]); }
            //for(int i = 0; i<Usernames.Length; i++) { Usernamesfile.WriteLine(Usernames); }
            //for(int i = 0; i<Accessibles.Length; i++) { Accessiblesfile.WriteLine(Accessibles); }
            //Accountsfile.Close();
            //Usernamesfile.Close();
            //Accessiblesfile.Close();

        }

        //This is outside the method because it shouldn't be reset to 0 every time the check box is clicked
        int DebugCounter = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checks to see if the box is checked, and displays the logbox if it is
            DebugCounter++;
            if (DebugCounter % 2 != 0){ LogBox.Visible = true; richTextBox1.Width = richTextBox1.Width - 180; }else{ LogBox.Visible = false; richTextBox1.Width = richTextBox1.Width + 180; }
        }

        private void NEWACCOUNT_CLICK(object sender, EventArgs e)
        {
            LogBox.AppendText("\"New Account\" button clicked\r\n");
            int newaccountarrayvalue = VerifyDoesntExist(inputText.Text);
            if (newaccountarrayvalue == 1000000000)
            { NewAccount(); RefreshArrays(); richTextBox1.Focus(); }
            else{ richTextBox1.AppendText("That account already exists, you need to select \"Change Information\" to do something about that.\r\n"); }
            
        }

        private void LISTACCOUNTS_CLICK(object sender, EventArgs e)
        {
            LogBox.AppendText("\"List TestAccounts\" button clicked\r\n");
            for (int i=0; i<Accounts.Length; i++)
            { richTextBox1.AppendText(Accounts[i] + "\r\n"); }

            //auto scroll the text box to show last output
            richTextBox1.Focus();
        }

        private void GetPasswordButton_Click(object sender, EventArgs e)
        {
            int accountarrayvalue = ValidateAccount(inputText.Text);
            if(accountarrayvalue != 1000000000)
            { GetPassword(accountarrayvalue); RefreshArrays(); richTextBox1.Focus(); }
        }

        private void CHANGEINFORMATION_CLICK(object sender, EventArgs e)
        {
            LogBox.AppendText("\"Change Information\" button clicked\r\n");
            int accountarrayvalue = ValidateAccount(inputText.Text);
            if(accountarrayvalue != 1000000000) { ChangeInfo(accountarrayvalue); RefreshArrays(); richTextBox1.Focus(); }
            
        }

        private void DELETEBUTTON_CLICK(object sender, EventArgs e)
        {
            LogBox.AppendText("Delete button clicked\r\n");
            int accountarrayvalue = ValidateAccount(inputText.Text);
            if(accountarrayvalue != 1000000000) { DeleteAccount(accountarrayvalue); RefreshArrays(); }
        }

        private Array GetAccounts()
        {
            string[] Accounts = File.ReadAllLines(@"C:\Users\Public\Documents\Accounts.txt");
            Form1 form1 = new Form1();
            form1.LogBox.AppendText("Accounts file Successfully read\r\n About to return as array variable");
           return (Accounts);
           
        }

        private void RefreshArrays()
        {
            //write the new account information to the text file
            File.WriteAllLines(@"C:\Users\Public\Documents\Accounts.txt", Accounts);
            File.WriteAllLines(@"C:\Users\Public\Documents\Usernames.txt", Usernames);
            File.WriteAllLines(@"C:\Users\Public\Documents\Accessibles.txt", Accessibles);

            //read the account information to the old arrays so that the form can now have updated information
            Accounts = File.ReadAllLines(@"C:\Users\Public\Documents\Accounts.txt");
            Usernames = File.ReadAllLines(@"C:\Users\Public\Documents\Usernames.txt");
            Accessibles = File.ReadAllLines(@"C:\Users\Public\Documents\Accessibles.txt");
        }

        private void GetPassword(int accountarrayvalue)
        {
            string username = Usernames[accountarrayvalue];
            richTextBox1.AppendText("Username:\t" + username + "\r\n");
            string password = Accessibles[accountarrayvalue];
            richTextBox1.AppendText("Password:\t" + password + "\r\n");
        }
        private void ChangeInfo(int accountarrayvalue)
        {
            //richTextBox1.AppendText("Would you like to change the username?");
            var result = MessageBox.Show("Would you like to change the username?", "Username Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ChangeUsername changeusernameForm = new ChangeUsername(this); changeusernameForm.ShowDialog();
                string newusername = changeusernamebox.Text;

                if (changeusernamebox.Text != string.Empty)
                {
                    Usernames[accountarrayvalue] = newusername;
                    richTextBox1.AppendText("The new username is: \t" + Usernames[accountarrayvalue] + "\r\n");
                }
                
            }// end if
            result = MessageBox.Show("Would you like to change the password?", "Password Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ChangePassword changepasswordForm = new ChangePassword(this); changepasswordForm.ShowDialog();
                string newpassword = changepasswordbox.Text;

                if (changepasswordbox.Text != string.Empty)
                {
                    Accessibles[accountarrayvalue] = newpassword;
                    richTextBox1.AppendText("The new password is: \t" + Accessibles[accountarrayvalue] + "\r\n");
                }
                
            }// end if

            //for (int i = 0; i<Usernames.Length; i++)
            //{richTextBox1.AppendText("Usernames array: \t" + Usernames[i]);}
            //for (int i = 0; i<Accessibles.Length; i++)
            //{ richTextBox1.AppendText("Passwords array: \t" + Accessibles[i]); }
            changeusernamebox.Clear(); changepasswordbox.Clear();
        }
        private void NewAccount()
        {
            NewAccount newaccountForm = new NewAccount(this);newaccountForm.ShowDialog();
            string newaccountname1 = newaccountbox.Text; string newaccountname = newaccountname1.ToUpper();
            if (newaccountbox.Text != String.Empty)
            {
                NewUsername newusernameForm = new NewUsername(this);newusernameForm.ShowDialog();
                string newusername = newusernamebox.Text;
                if (newusernamebox.Text != String.Empty)
                {
                    NewPassword newpasswordForm = new NewPassword(this);newpasswordForm.ShowDialog();
                    string newpassword = newpasswordbox.Text;
                    if (newpasswordbox.Text != String.Empty)
                    {
                        //create new arrays that are one unit longer than current account arrays to store the new account in the last spot
                        string[] NewAccountsArray = new string[Accounts.Length + 1];
                        string[] NewUsernamesArray = new string[Usernames.Length + 1];
                        string[] NewPasswordsArray = new string[Accessibles.Length + 1];
                        
                        //fill the new arrays with the information from the old accounts array
                        for (int i = 0; i < Accounts.Length; i++)
                        { NewAccountsArray[i] = Accounts[i]; NewUsernamesArray[i] = Usernames[i];NewPasswordsArray[i] = Accessibles[i]; }
                        
                        //make the final spot in the new array the new account information
                        NewAccountsArray[Accounts.Length] = newaccountname;
                        NewUsernamesArray[Usernames.Length] = newusername;
                        NewPasswordsArray[Accessibles.Length] = newpassword;

                        //write the new account information to the text file
                        File.WriteAllLines(@"C:\Users\Public\Documents\Accounts.txt", NewAccountsArray);
                        File.WriteAllLines(@"C:\Users\Public\Documents\Usernames.txt", NewUsernamesArray);
                        File.WriteAllLines(@"C:\Users\Public\Documents\Accessibles.txt", NewPasswordsArray);

                        //read the account information to the old arrays so that the form can now have updated information
                        Accounts = File.ReadAllLines(@"C:\Users\Public\Documents\Accounts.txt");
                        Usernames = File.ReadAllLines(@"C:\Users\Public\Documents\Usernames.txt");
                        Accessibles = File.ReadAllLines(@"C:\Users\Public\Documents\Accessibles.txt");

                        //StreamWriter Accountsfile = new StreamWriter(@"C:\Users\Public\Documents\Accounts.txt");
                        //StreamWriter Accessiblesfile = new StreamWriter(@"C:\Users\Public\Documents\Accessibles.txt");
                        //StreamWriter Usernamesfile = new StreamWriter(@"C:\Users\Public\Documents\Usernames.txt");
                        //for (int i = 0; i < Accounts.Length; i++) { Accountsfile.WriteLine(Accounts[i]); }
                        //for (int i = 0; i < Usernames.Length; i++) { Usernamesfile.WriteLine(Usernames[i]); }
                        //for (int i = 0; i < Accessibles.Length; i++) { Accessiblesfile.WriteLine(Accessibles[i]); }
                        //Accountsfile.WriteLine(newaccountname); 
                        //Usernamesfile.WriteLine(newusername); 
                        //Accessiblesfile.WriteLine(newpassword); 
                        //Accountsfile.Close();Accessiblesfile.Close();Usernamesfile.Close();
                        //Accounts[Accounts.Length + 1] = newaccountname;
                        richTextBox1.AppendText("The new account name is: \t" + newaccountname + "\r\n");
                        //Accountsfile.WriteLine(newaccountname);Accountsfile.Close();
                        

                        //Usernames[Usernames.Length + 1] = newusername;
                        richTextBox1.AppendText("The new username for the account is: \t" + newusername + "\r\n");
                       // Usernamesfile.WriteLine(newusername);Usernamesfile.Close();
                        

                        //Accessibles[Accessibles.Length + 1] = newpassword;
                        richTextBox1.AppendText("The new password for the account is: \t" + newpassword + "\r\n");
                        //Accessiblesfile.WriteLine(newpassword); Accessiblesfile.Close();
                        
                    }
                }
            }
            newaccountbox.Clear();newusernamebox.Clear();newpasswordbox.Clear();
        }
        private void DeleteAccount(int accountarrayvalue)
        {
            //Accounts[accountarrayvalue] = string.Empty;
            //Usernames[accountarrayvalue] = string.Empty;
            //Accessibles[accountarrayvalue] = string.Empty;

            //create new arrays that are one unit shorter than current account arrays
            string[] NewAccountsArray = new string[Accounts.Length - 1];
            string[] NewUsernamesArray = new string[Usernames.Length - 1];
            string[] NewPasswordsArray = new string[Accessibles.Length - 1];

            //fill the new arrays with the information from the old accounts array disregarding the array index that is to be deleted
            for (int i = 0; i < Accounts.Length; i++)
            { if (i != accountarrayvalue) { NewAccountsArray[i] = Accounts[i]; NewUsernamesArray[i] = Usernames[i]; NewPasswordsArray[i] = Accessibles[i]; } }

            //write the new account information to the text file
            File.WriteAllLines(@"C:\Users\Public\Documents\Accounts.txt", NewAccountsArray);
            File.WriteAllLines(@"C:\Users\Public\Documents\Usernames.txt", NewUsernamesArray);
            File.WriteAllLines(@"C:\Users\Public\Documents\Accessibles.txt", NewPasswordsArray);

            //read the account information to the old arrays so that the form can now have updated information
            Accounts = File.ReadAllLines(@"C:\Users\Public\Documents\Accounts.txt");
            Usernames = File.ReadAllLines(@"C:\Users\Public\Documents\Usernames.txt");
            Accessibles = File.ReadAllLines(@"C:\Users\Public\Documents\Accessibles.txt");

            //StreamWriter Accountsfile = new StreamWriter(@"C:\Users\Public\Documents\Accounts.txt");
            //StreamWriter Accessiblesfile = new StreamWriter(@"C:\Users\Public\Documents\Accessibles.txt");
            //StreamWriter Usernamesfile = new StreamWriter(@"C:\Users\Public\Documents\Usernames.txt");
            //for (int i = 0; i < Accounts.Length; i++) { Accountsfile.WriteLine(Accounts[i]); }
            //for (int i = 0; i < Usernames.Length; i++) { Usernamesfile.WriteLine(Usernames[i]); }
            //for (int i = 0; i < Accessibles.Length; i++) { Accessiblesfile.WriteLine(Accessibles[i]); }
            //Accountsfile.Close(); Usernamesfile.Close(); Accessiblesfile.Close();
            //foreach (string line in Accounts)
            //{
            //    if (!line.Contains(Accounts[accountarrayvalue]))
            //    { Accountsfile.WriteLine(line); }
            //}
            //foreach (string line in Usernames)
            //{
            //    if (!line.Contains(Usernames[accountarrayvalue]))
            //    { Usernamesfile.WriteLine(line); }
            //}
            //foreach (string line in Accessibles)
            //{
            //    if (!line.Contains(Accessibles[accountarrayvalue]))
            //    { Accessiblesfile.WriteLine(line); }
            //}
            //Accountsfile.Close();
            //Usernamesfile.Close();
            //Accessiblesfile.Close();

        }
        private int ValidateAccount(string input)
        {
            //string accountinput1 = inputText.Text;
            //inputText.Clear();
            string accountinput = input.ToUpper();
            inputText.Clear();
            LogBox.AppendText("account input receieved\r\n");

            LogBox.AppendText("Checking to see if input matches records...\r\n");

            //check if any input at all
            if (accountinput == "") { accountinput = "I DIDN'T PUT ANYTHING IN THE DIALOGUE BOX AND I NEED TO PUT SOMETHING HERE SO THAT THE VARIABLE NULL ISN'T RETURNED SO THIS IS JUST A REALLY LONG MESSAGE BECAUSE THERE IS NO WAY AN ACCOUNT WOULD HAVE THIS TITLE"; }

            //check if account exists
            if (Accounts.Contains(accountinput))
            {
                Form1 form1 = new Form1(); form1.LogBox.AppendText("Account verified, retrieving information");

                //as long as the account exists, find the index number of the account to pass to other methods.
                string account = accountinput;
                int accountarrayvalue = Array.IndexOf(Accounts, account);
                richTextBox1.AppendText(account + "\r\n");
                return (accountarrayvalue);
            }
            else { richTextBox1.AppendText("Account not found\r\n"); return (1000000000); }
        }//end ValidateAccount
        private int VerifyDoesntExist(string input)
        {
            string accountinput = input.ToUpper();
            inputText.Clear();
            LogBox.AppendText("account input receieved\r\n");

            LogBox.AppendText("Checking to see if input matches records...\r\n");

            //check if any input at all and if none, assume that it is the 1 googlth' input and can't be dealt with
            if (accountinput == "") { accountinput = "I DIDN'T PUT ANYTHING IN THE DIALOGUE BOX AND I NEED TO PUT SOMETHING HERE SO THAT THE VARIABLE NULL ISN'T RETURNED SO THIS IS JUST A REALLY LONG MESSAGE BECAUSE THERE IS NO WAY AN ACCOUNT WOULD HAVE THIS TITLE"; }

            //check if account exists
            if (Accounts.Contains(accountinput))
            {
                Form1 form1 = new Form1(); form1.LogBox.AppendText("Account verified, retrieving information");

                //as long as the account exists, find the index number of the account to pass to other methods.
                string account = accountinput;
                int accountarrayvalue = Array.IndexOf(Accounts, account);
                richTextBox1.AppendText(account + "\r\n");
                return (accountarrayvalue);
            }
            else { richTextBox1.AppendText("Account not found\r\n"); return (1000000000); }

        }//end VerifyDoesn'tExist
    } //end class
}//end namespace
