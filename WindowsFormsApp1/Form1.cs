using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int _clr = -1;
        private string _str;
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "RegistrySetValueExample";
        const string keyName = userRoot + "\\" + subkey;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((int)Registry.GetValue(keyName, "clr", "-1") == 0)
                Collor(Color.DarkSlateGray, Color.Gray);
            if ((int)Registry.GetValue(keyName, "clr", "-1") == 1)
                Collor(Color.DeepPink, Color.Pink);
        }

        private void Collor(Color buttonc, Color backgroundc)
        {
            button1.BackColor = buttonc;
            button2.BackColor = buttonc;
            BackColor = backgroundc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Collor(Color.DarkSlateGray, Color.Gray);
            _clr = 0;
            Registry.SetValue(keyName, "clr", 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Collor(Color.DeepPink, Color.Pink);
            _clr = 1;
            Registry.SetValue(keyName, "clr", 1);
        }
    }
}
