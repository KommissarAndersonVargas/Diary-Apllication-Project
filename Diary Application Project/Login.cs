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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UserSelect.Text = Properties.Settings.Default.User_name;
            UserSelect.Items.Add(Properties.Settings.Default.User_name);
            UserSelect.Items.Add(Properties.Settings.Default.User2);
            UserSelect.Items.Add(Properties.Settings.Default.User3);

            userName.Text = Properties.Settings.Default.User_name;
        }
    
        private void Info_Click(object sender, EventArgs e)
        {
            About_Us aboutUs = new About_Us();
            aboutUs.Show();
        }

        private void new_user_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string copyPassWord = Properties.Settings.Default.User_pass;
            string copyUserName = Properties.Settings.Default.User_name;

            if (passWord.Text.Equals(copyPassWord) && userName.Text.Equals(copyUserName))
                this.Close();

            else if (passWord.Text == "")
                MessageBox.Show("The passaword is null, please enter with your password", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            else
                MessageBox.Show("Wrong password or username. Please try again","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);        
        }

        private void forgot_password_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Closing the Application", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit(); // fecha o programa
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = UserSelect.SelectedItem.ToString();
            userName.Text = selection;
        }

    }
}
