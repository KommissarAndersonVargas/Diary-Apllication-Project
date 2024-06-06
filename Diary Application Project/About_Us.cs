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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Diary_Application_Project
{
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void link_about_us_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string emailSearch = "anderson-vargas@uergs.edu.br";

            string link = $"https://mail.google.com/mail/?view=cm&fs=1&to={emailSearch}";

            // Abre o navegador Microsoft Edge com o link
            Process.Start("msedge", link);
        }

        private void About_Us_Load(object sender, EventArgs e)
        {
            GetVersion();
        }
        public void GetVersion()
        {
            this.version_number.Text = Application.ProductVersion.ToString();
        }
    }
}
