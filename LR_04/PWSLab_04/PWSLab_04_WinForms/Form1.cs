using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWSLab_04_WinForms
{
    public partial class Form1 : Form
    {
        WS.SimplexSoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new WS.SimplexSoapClient();
        }

        private void getSumButton_Click(object sender, EventArgs e)
        {
            WS.A a1 = new WS.A();
            a1.s = s1.Text;
            a1.k = int.Parse(k1.Text);
            a1.f = float.Parse(f1.Text);

            WS.A a2 = new WS.A();
            a2.s = s2.Text;
            a2.k = int.Parse(k2.Text);
            a2.f = float.Parse(f2.Text);

            WS.A result = client.Sum(a1, a2);

            result_1.Text = result.s;
            result_2.Text = result.k.ToString();
            result_3.Text = result.f.ToString();
        }
    }
}
