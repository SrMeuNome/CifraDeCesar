using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Adicionei essas duas bibliotecas
using System.Windows.Forms;
using System.Drawing;

namespace TelaDescriptografia
{
    public class txtLimitador : TextBox //Adicionei o tipo TextBox
    {
        protected override void OnKeyDown(KeyEventArgs e) //Adicionando Código
        {
            base.OnKeyDown(e);

/*if (!(char.IsLetter(e.)))
            {
                e.Handled = true;
            }*/
        }
    }
}
