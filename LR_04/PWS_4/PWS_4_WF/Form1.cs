using PWS_4_WF.Simplex_VSA;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PWS_4_WF
{
    public partial class Form1 : Form
    {
       //SimplexSoapClient simplex_client;
        Simplex simplex_client;

        public Form1()
        {
           //this.simplex_client = new SimplexSoapClient();
           this.simplex_client = new Simplex();
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            try
            {
                // for connected service
               // Simplex_VSA.A obj1 = new Simplex_VSA.A();
                //Simplex_VSA.A obj2 = new Simplex_VSA.A();

                // for simplex proxy
               A obj1 = new A();
                A obj2 = new A();
               //
               obj1.s = this.textBoxS1.Text;
               obj1.k = int.Parse(this.textBoxK1.Text);
               obj1.f = float.Parse(this.textBoxF1.Text);
              
               obj2.s = this.textBoxS2.Text;
               obj2.k = int.Parse(this.textBoxK2.Text);
               obj2.f = float.Parse(this.textBoxF2.Text);

                // for connected service
               //Simplex_VSA.A resultObj = simplex_client.Sum(obj1, obj2);

                // for simplex proxy 
                A resultObj = simplex_client.Sum(obj1, obj2);
                //
                //
                this.textBoxResultF.Text = resultObj.f.ToString();
                this.textBoxResultK.Text = resultObj.k.ToString();
                this.textBoxResultS.Text = resultObj.s;
            }
            catch (Exception ex)
            {
                this.labelError.Text = "Error";
                this.labelError.ForeColor = Color.Red;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxF1.Text = "";
            this.textBoxS1.Text = "";
            this.textBoxK1.Text = "";
            this.textBoxF2.Text = "";
            this.textBoxS2.Text = "";
            this.textBoxK2.Text = "";
            this.textBoxResultS.Text = "";
            this.textBoxResultF.Text = "";
            this.textBoxResultK.Text = "";
            this.labelError.Text = "";
        }

        private void textBoxF1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
