using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string curso = TextBox1.Text;
            int nota = Convert.ToInt32(TextBox2.Text),
                nota1 = Convert.ToInt32(TextBox3.Text)
                , nota2 = Convert.ToInt32(TextBox4.Text)
                , nota3 = Convert.ToInt32(TextBox5.Text);

            int[] notas = { nota, nota1, nota2, nota3 };

            int temporal = int.MaxValue;
            float prom = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < temporal)
                {
                    temporal = notas[i];
                }
            }


            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] != temporal)
                {
                    prom += notas[i];
                }

            }

            prom = prom / 3;
            TextBox6.Text = prom.ToString();
            if (prom >= 10.5)
            {
                TextBox7.Text = "Aprobado";
            }
            else
            {
                TextBox7.Text = "Desaprobado";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
        }
    }
}