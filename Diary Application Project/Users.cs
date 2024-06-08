using Diary_Application_Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Application_Project
{
    public partial class Users : Form
    {
        string userName = string.Empty;
        string passWord = string.Empty;
        string passWordConfirm = string.Empty;
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            GetVersion();
        }
        public void GetVersion()
        {
            this.version_number.Text = Application.ProductVersion.ToString();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            userName = userNameBox.Text.ToString();
            passWord = passwordBox.Text.ToString();
            passWordConfirm = psswConfirmBox.Text.ToString();
            SaveResourceInfo();
            var conditionLoad = userName.Length > 0 && passWord.Length > 0 && passWordConfirm.Length > 0;

            if (conditionLoad)
            {
                if (CheckPassWord())
                {
                    UserInfo userInfo = new UserInfo(userName, passWord, passWordConfirm);
                    MessageBox.Show("All information saved successfully");
                }
                if (!CheckPassWord())
                {
                    MessageBox.Show("All the information must be informated corretly to continue");
                }
            }
            else
            {
                MessageBox.Show("All the information must be informated to continue");
            }
        }
        public bool CheckPassWord()
        {
            if (this.passWord.Equals(passWordConfirm))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SaveResourceInfo()
        {
            Properties.Settings.Default.User_name = userName;
            Properties.Settings.Default.User_pass = passWord;
            Properties.Settings.Default.Save();
        }
    }
}
