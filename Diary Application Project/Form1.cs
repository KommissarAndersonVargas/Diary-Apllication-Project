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
using System.Security.Policy;
using OpenQA.Selenium.DevTools.V123.Emulation;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.Web.WebView2.Core;

namespace Diary_Application_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWebView();
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
            SetColorChanged();
            LoadDefaultSettings();
            SetUserImage();
        }
        private void SetUserImage()
        {
            var IsUsingSetImege = Properties.Settings.Default.IsUsingSetImage;

            if (IsUsingSetImege)
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.PathBackGorundImage);
            }
        }
        private void SetColorChanged()
        {
            var settingcolor = Properties.Settings.Default.UserColor;
            this.panel2.BackColor = settingcolor;
            this.toolStrip1.BackColor = settingcolor;
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

            try
            {
                string searchString = itenToSearch.Replace(" ", "_"); // Substitua pela string que você quer pesquisar
                string edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"; // Caminho 
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = edgePath,
                    Arguments = $"https://www.bing.com/search?q={searchString}",
                    UseShellExecute = true
                };
                Process.Start(startInfo);
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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog.ShowDialog();
            Properties.Settings.Default.UserColor = this.colorDialog.Color;
            var settingcolor = Properties.Settings.Default.UserColor;
            settingcolor = this.colorDialog.Color;
            this.panel2.BackColor = settingcolor;
            this.toolStrip1.BackColor = settingcolor;
            Properties.Settings.Default.Save();
        }
        //here
        private void imageThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                    Properties.Settings.Default.PathBackGorundImage = openFileDialog.FileName;
                    Properties.Settings.Default.IsUsingSetImage = true;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void defaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserColor = Color.LightSlateGray;
            var settingcolor = Properties.Settings.Default.UserColor;
            this.panel2.BackColor = settingcolor;
            this.toolStrip1.BackColor = settingcolor;
            var backImage = Properties.Resources.bears3;
            this.BackgroundImage = backImage;
            Properties.Settings.Default.backImageUsing = true;
            Properties.Settings.Default.IsUsingSetImage = false;
            this.BackgroundImage = Properties.Resources.bears3;
            Properties.Settings.Default.Save();
        }
        private void LoadDefaultSettings()
        {
            var isEnable = Properties.Settings.Default.backImageUsing;
            if (isEnable)
            {
                Properties.Settings.Default.UserColor = Color.LightSlateGray;
                var backImage = Properties.Resources.bears3;
                this.BackgroundImage = backImage;
                Properties.Settings.Default.UserColor = Color.LightSlateGray;
                var settingcolor = Properties.Settings.Default.UserColor;
                this.panel2.BackColor = settingcolor;
                this.toolStrip1.BackColor = settingcolor;
                Properties.Settings.Default.backImageUsing = false; 
                Properties.Settings.Default.Save();
            }
        }
        
        public async void InitializeWebView()
        {
            try
            {
                // Configurar o ambiente do WebView2
                var environment = await CoreWebView2Environment.CreateAsync(null, null, null);

                // Aguardar a inicialização
                await webView.EnsureCoreWebView2Async(environment);

                // Configurar o WebView2
                webView.CoreWebView2.Settings.AreDevToolsEnabled = true;
                webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
                webView.CoreWebView2.Settings.IsZoomControlEnabled = true;


                webView.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36";

                // Navegar para o Copilot (Bing Chat)
                webView.CoreWebView2.Navigate("https://copilot.microsoft.com/");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar WebView2: {ex.Message}");
            }
        }
    }
}
