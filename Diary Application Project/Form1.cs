using Diary_Application_Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Keys = OpenQA.Selenium.Keys;
using OpenQA.Selenium.Edge;

namespace Diary_Application_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.Close();

            else {} // Nao faz nada
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackToPc_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTimeNow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            GetTimeNow();
            GetVersion();
            user_name.Text = Properties.Settings.Default.User_name;
            Login login = new Login();
            login.ShowDialog();
        }
        public void GetTimeNow() 
        {
            this.timer_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void GetVersion()
        {
            this.versionrelease_label.Text = Application.ProductVersion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itenToSearch = serach_on_google.Text.ToString();
            ToSerach.TextToSaerch = itenToSearch;
            SearchOnGoogleChrome(itenToSearch);

        }
        public void SearchOnGoogleChrome(string itenToSearch)
        {
            IWebDriver driver = new EdgeDriver();

            try
            {
                // Abre o Edge Microsoft
                driver.Navigate().GoToUrl("https://www.google.com");

                // Localiza a caixa de pesquisa e insere o texto
                IWebElement searchBox = driver.FindElement(By.Name("q"));
                searchBox.SendKeys(itenToSearch);

                // Pressiona Enter para iniciar a pesquisa
                searchBox.SendKeys(Keys.Enter);
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred");
            }

        }
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us aboutUs = new About_Us();
            aboutUs.Show();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            serach_on_google.Clear();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void loockScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void AddMemo_Click(object sender, EventArgs e)
        {
            Memo memo = new Memo();
            memo.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = System.Diagnostics.Process.Start("calc.exe");
            process.WaitForInputIdle();
        }

        private void openExcelContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExcel openExcel = new OpenExcel();
            openExcel.Show();
        }
    }
}
