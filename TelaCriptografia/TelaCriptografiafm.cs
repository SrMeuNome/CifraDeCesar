using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCriptografia
{
    public partial class TelaCriptografiafm : Form
    {
        public TelaCriptografiafm()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            string texto = TextoCriptografia.Text;
            string codigoEncript = "";


            for (int i = 0; i < texto.Length; i++)
            {
                int codigoTexto = Convert.ToInt32(texto[i]);
                if (codigoTexto == 10 || codigoTexto == 13)
                {
                    codigoEncript += Char.ConvertFromUtf32(codigoTexto);
                    continue;
                } else if (codigoTexto >= 65 && codigoTexto <= 90)
                {
                    codigoTexto += 32;
                }

                codigoTexto += (int)ValorGuardado.Value; //O codigo de saltar linha cresce de 101 em 101 e começa em 1310

                if (codigoTexto == 32 + (int)ValorGuardado.Value)
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
            TextoCriptografado.Text = codigoEncript;

            /*
            namespace Crypto_Cesar
            {
            class Program
            {
            static void Main(string[] args)
            {

            //declaração das variáveis
            string palavra, encrypt = "";

            //Esta é a perfumaria que eu falei...
            //método write escreve na tela do prompt do usuario
            Console.Write("|---------------------------------|\n");
            Console.Write("| 1 - Criptografar um mensagem    |\n");
            Console.Write("| 2 - Decriptografar uma mensagem |\n");
            Console.Write("| 0 - Sair                        |\n");
            Console.Write("|---------------------------------|\n");
            Console.Write(" Escolha a opçao: ");

            //Aqui é feito uma conversão, pois o opcao é inicialmente uma string
            int opcao = int.Parse(Console.ReadLine());

            //depois da conversão o switch verifica a opcao digitada
            switch (opcao)

            {

            //caso a opcao seja 1
            case 1: Console.Write("Entre com a mensagem para ser criptografada: ");

            //palavra é a variavel que o usuario vai digitar
            //O método .ToLower() transforma qualquer letra maiúscula em minúscula
            palavra = Console.ReadLine().ToLower();

            //enquanto a palavra for menor que i
            for (int i = 0; i < palavra.Length; i++)

            {
            //Devolve o codigo ASCII da letra
            int ASCII = (int)palavra[i];

            //Coloca a chave fixa adicionando 10 posições no numero da tabela ASCII
            int ASCIIC = ASCII + 10;

            //Concatena o texto e o coloca na variável
            encrypt += Char.ConvertFromUtf32(ASCIIC);
            }

            //Mostra o resultado final, concatenando a variável em que está o texto cifrado
            Console.Write("Resultado: " + encrypt);

            //Aguarda o usuário pressionar uma tecla para sair
            Console.ReadKey();

            //representa o final do case 1
            break;

            //caso a opcao escolhida for 2
            case 2: Console.Write("Entre com a mensagem para ser decriptografada: ");

            palavra = Console.ReadLine().ToLower();

            for (int i = 0; i < palavra.Length; i++)

            {

            int ASCII = (int)palavra[i];

            //Coloca a chave fixa retirando 10 posições no numero da tabela ASCII
            int ASCIIC = ASCII - 10;

            encrypt += Char.ConvertFromUtf32(ASCIIC);

            }

            Console.Write(encrypt);

            Console.ReadKey();

            break;

            }

            }

            }

            }
            */
        }

        private void TelaCriptografiafm_Load(object sender, EventArgs e)
        {

        }

        private void ChaveSecreta_Click(object sender, EventArgs e)
        {

        }
    }
}
