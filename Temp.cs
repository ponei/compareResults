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
    public partial class Temp : Form
    {
        public Temp()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Temp_FormClosing); //evento pra quando o form estiver fechando
        }

        private void Temp_Load(object sender, EventArgs e)
        {
            
        }

        public void updateInfo()
        {
            txtbTemp.Text = Comparador.txtbT; //coloca a variavel de texto nessa textbox aqui
            lbTempo.Text = "Última cópia temporária feita em: " + DateTime.Now.ToString("HH:mm") + " [" + DateTime.Now.ToString("dd/MM/yy") + "]"; //info de em que hora e data foi feita a ultima copia
        }

        private void Temp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //cancela o fechamento
            Hide(); //esconde form ao invez de fechar
        }
    }
}
