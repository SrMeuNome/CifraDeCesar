using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifraDeCesar
{
    public partial class TelaInicialfm : Form
    {
        public TelaInicialfm()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxCriptografia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCriptografia.Checked)
            {
                this.Visible = false;
                TelaCriptografia.TelaCriptografiafm criptografia = new TelaCriptografia.TelaCriptografiafm();
                criptografia.ValorGuardado = CaixaChave;
                criptografia.ShowDialog();
            }
            checkBoxCriptografia.Checked = false;
            this.Visible = true;
        }

        private void checkBoxDescriptografia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDescriptografia.Checked)
            {
                this.Visible = false;
                TelaDescriptografia.TelaDescriptografiafm criptografia = new TelaDescriptografia.TelaDescriptografiafm();
                criptografia.ValorGuardado = CaixaChave;
                criptografia.ShowDialog();
            }
            checkBoxDescriptografia.Checked = false;
            this.Visible = true;
        }
    }
}
