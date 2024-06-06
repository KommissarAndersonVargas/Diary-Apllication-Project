using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Application_Project.Class
{
    public class UserInfo
    {
        public string Name { get; set; }

        public string PassWord { get; set; }

        public string PassWordConfirm { get; set; }

        public UserInfo(string name, string passWord, string passWordConfirm)
        {
            Name = name;
            PassWord = passWord;
            PassWordConfirm = passWordConfirm;
        }
    }
}
