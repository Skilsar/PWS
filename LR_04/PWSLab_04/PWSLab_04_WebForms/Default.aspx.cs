using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PWSLab_04_WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        private Simplex clientex;

        protected void Page_Load(object sender, EventArgs e)
        {
            clientex = new MyPerfectService();
        }

        protected void sum_Click(object sender, EventArgs e)
        {
            int val1, val2;
            if (int.TryParse(x.Text.ToString(), out val1) && int.TryParse(y.Text.ToString(), out val2))
            {
                result.Text = clientex.Add(val1, val2).ToString();
            }
            else
            {
                result.Text = "Error!";
            }
        }

        protected void sum_Click_concat(object sender, EventArgs e)
        {
            string str1 = x.Text.ToString();
            double val2;

            if (double.TryParse(y.Text.ToString(), out val2))
            {
                result.Text = str1 + val2.ToString();
            }
            else
            {
                result.Text = "Error!";
            }
        }

        protected void DetermineAndOperate(object sender, EventArgs e)
        {
            string str1 = x.Text.ToString();
            string str2 = y.Text.ToString();

            double val1, val2;
            int intVal1, intVal2;
            float floatVal1, floatVal2;

            if (double.TryParse(str1, out val1) && double.TryParse(str2, out val2))
            {
                // Оба значения - тип double
                result.Text = (val1 + val2).ToString();
            }
            else if (int.TryParse(str1, out intVal1) && int.TryParse(str2, out intVal2))
            {
                // Оба значения - тип int
                result.Text = (intVal1 + intVal2).ToString();
            }
            else if (float.TryParse(str1, out floatVal1) && int.TryParse(str2, out intVal2))
            {
                // str1 - тип float, str2 - тип int
                result.Text = (floatVal1 + intVal2).ToString();
            }
            else if (int.TryParse(str1, out intVal1) && float.TryParse(str2, out floatVal2))
            {
                // str1 - тип int, str2 - тип float
                result.Text = (intVal1 + floatVal2).ToString();
            }
            else if (float.TryParse(str1, out floatVal1) && float.TryParse(str2, out floatVal2))
            {
                // Оба значения - тип float
                result.Text = (floatVal1 + floatVal2).ToString();
            }
            else
            {
                // Хотя бы одно значение - строка, выполняем конкатенацию
                result.Text = str1 + str2;
            }
        }
    }
}