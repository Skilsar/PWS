using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWSLab_04_WinFormsProxy
{
    public partial class Form1 : Form
    {
        private Simplex clientex;

        public Form1()
        {
            InitializeComponent();
            clientex = new Simplex();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(xTextBox.Text);
                int y = Int32.Parse(yTextBox.Text);
                resultTextBox.Text = clientex.Add(x, y).ToString();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
