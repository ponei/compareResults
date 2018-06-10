using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compareResults
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Config_FormClosing); //evento pra quando o form estiver fechando
        }        

        private void btTrocar_Click(object sender, EventArgs e)
        {
            if (Comparador.ctipo == 1) //checa o tipo de compare
            {
                Comparador.ctipo = 2; //muda o tipo de compare
                lbTipo.Text = "Comparando arquivo 2 com arquivo 1"; //atualiza o texto da label
            }
            else
            {
                Comparador.ctipo = 1; //muda o tipo de compare
                lbTipo.Text = "Comparando arquivo 1 com arquivo 2"; //atualiza o texto da label
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //cancela o fechamento
            Hide(); //esconde form ao invez de fechar
        }

        private void btTFormat_Click(object sender, EventArgs e)
        {
            if (Comparador.ftipo == 1) //checa o tipo de formatacao
            {
                Comparador.ftipo = 2; //muda o tipo de formatacao
                lbFormat.Text = "\"0x00000(1): exemplo\" vira \"exemplo\" (PH2)"; //atualiza o texto da label
            }
            else
            {
                Comparador.ftipo = 1; //muda o tipo de formatacao
                lbFormat.Text = "Nenhuma"; //atualiza o texto da label
            }
        }
    }
}
