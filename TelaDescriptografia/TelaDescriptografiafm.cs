using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDescriptografia
{
    public partial class TelaDescriptografiafm : Form
    {
        public TelaDescriptografiafm()
        {
            InitializeComponent();
        }

        private void TextoDescriptografia_TextChanged(object sender, EventArgs e)
        {
            /*if (!(char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }*/
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            string texto = TextoDescriptografia.Text;
            string codigoEncript = "";


            for (int i = 0; i < texto.Length; i++)
            {
                int codigoTexto = Convert.ToInt32(texto[i]);
                if (codigoTexto == 10 || codigoTexto == 13)
                {
                    codigoEncript += Char.ConvertFromUtf32(codigoTexto);
                    continue;
                }
                else if (codigoTexto >= 65 && codigoTexto <= 90)
                {
                    codigoTexto += 32;
                }

                codigoTexto -= (int)ValorGuardado.Value;

                if (codigoTexto == 32 - (int)ValorGuardado.Value)
                {
                    codigoTexto = 32;
                } else if (codigoTexto < 97)
                {
                    codigoTexto = 122 - (97 - codigoTexto); // é 123 pois na subtração vai contar o "z"
                } else if (codigoTexto > 122)
                {
                    codigoTexto = 97 + (codigoTexto - 122); // é 96 pois na soma vai contar o "a"
                }
                codigoEncript += Char.ConvertFromUtf32(codigoTexto);// codigoTexto;
            }
            TextoDescriptografado.Text = codigoEncript;
        }
    }
}
