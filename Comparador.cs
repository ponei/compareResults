using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace compareResults
{
    public partial class Comparador : Form
    {
        #region "variaveis"
        string file1, file2; //variavel pro diretorio dos arquivos
        public static string txtbT;
        bool f1 = false, f2 = false; //bool pra ver se os arquivos foram escolhidos
        public static int ctipo = 1, ftipo = 1; //tipo de compare, formatacao
        int stest = 0, sigu = 0, sdif = 0, sbla = 0; //variavel pra contagem de strings
        Config cfrm = new Config(); //form de config
        Temp ctmp = new Temp(); //form temp
        #endregion

        public Comparador()
        {
            InitializeComponent(); //inicializa este cu
        }

        #region "metodos"
        private void controlsChecando()
        {
            //atualiza todos os controles quando o usuario clicar pra comparar
            btConfig.Enabled = false; //botao de trocar tipo de compare
            btFile1.Enabled = false; //botao de selecionar arquivo 1
            btFile2.Enabled = false; //botao de selecionar arquivo 2
            btComparar.Enabled = false; //botao de comparar
            lbFazendo.Text = "Fazendo: Checando"; //label de status
            btParar.Visible = true; //botao pra parar compare fica visivel
        }

        private void controlsParado()
        {
            //atualiza todos os controles quando o usuario clicar pra parar o compare
            btConfig.Enabled = true; //botao de trocar tipo de compare
            btFile1.Enabled = true; //botao de selecionar arquivo 1
            btFile2.Enabled = true; //botao de selecionar arquivo 2
            btComparar.Enabled = true; //botao de comparar
            lbFazendo.Text = "Fazendo: Nada"; //label de status
            btParar.Visible = false; //botao pra parar compare fica invisivel
        }

        private void updateInfo()
        {
            //atualiza as labels pra aparecer a contagem de strings na tela
            lbStest.Text = "Strings testadas: " + stest;
            lbSigu.Text = "Strings iguais: " + sigu;
            lbSdif.Text = "Strings diferentes: " + sdif;
            lbSbla.Text = "Strings blacklisteds: " + sbla;
        }

        private bool checarCompare(string linha, int tipo)
        {
            if (ctipo == 1) //checa o tipo de compare
            {
                using (FileStream fs = File.Open(file2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) //filestream pra indicar o arquivo de texto e argumentos
                {
                    using (BufferedStream bs = new BufferedStream(fs)) //bufferedstream pra nao fuder a memoria ram
                    {
                        using (StreamReader sr = new StreamReader(bs)) //streamreader pra ler o arquivo
                        {
                            string line; //declara uma string pra linha
                            while ((line = sr.ReadLine()) != null) //le linha por linha
                            {
                                if (line.Contains(linha)) //se linha conter argumento
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
            else
            {
                using (FileStream fs = File.Open(file1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) //filestream pra indicar o arquivo de texto e argumentos
                {
                    using (BufferedStream bs = new BufferedStream(fs)) //bufferedstream pra nao fuder a memoria ram
                    {
                        using (StreamReader sr = new StreamReader(bs)) //streamreader pra ler o arquivo
                        {
                            string line; //declara uma string pra linha
                            while ((line = sr.ReadLine()) != null) //le linha por linha
                            {
                                if (line.Contains(linha)) //se linha conter argumento
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }
        #endregion

        #region "event de control"
        private void btComparar_Click(object sender, EventArgs e)
        {
            //atualiza as variaveis de contagem de string
            stest = 0;
            sigu = 0;
            sdif = 0;
            sbla = 0;
            //limpa a textbox de strings diferentes
            txtbStrings.Text = "";
            //fecha form de config, se tiver aberto
            cfrm.Hide();

            if (f2 != false && f1 != false) //se os 2 arquivos de texto tiverem setados
            {
                timerInfo.Start(); //começa o timer pra aparecer a contagem de strings na tela
                controlsChecando(); //atualiza os controles
                if (ctipo == 1) //checa o tipo de compare
                {
                    cTipo1.RunWorkerAsync(); //começa o backgroundworker pra comparar os 2 arquivos de texto
                }
                else
                {
                    cTipo2.RunWorkerAsync(); //começa o backgroundworker pra comparar os 2 arquivos de texto
                }
            }
            else
            {
                MessageBox.Show("Seleciona os 2 arquivos arrombado"); //msg fofinha se o usuario tiver down
            }
        }

        private void btFile2_Click(object sender, EventArgs e)
        {
            if (coisinhaDeEscolherArquivoLol.ShowDialog() == DialogResult.OK) //se arquivo for escolhido e usuario clicar em ok
            {
                file2 = coisinhaDeEscolherArquivoLol.FileName; //seta a variavel que indica o diretorio com o arquivo de texto escolhido
                f2 = true; //atualiza o bool que indica se arquivo foi setado ou nao
            }
        }

        private void btParar_Click(object sender, EventArgs e)
        {
            if (ctipo == 1) //checa o tipo de compare
            {
                cTipo1.CancelAsync(); //cancela o compare
                controlsParado(); //atualiza os controles
                timerInfo.Stop(); //para de atualizar as label pra aparecer a contagem de strings na tela
            }
            else
            {
                cTipo2.CancelAsync(); //cancela o compare
                controlsParado();  //atualiza os controles
                timerInfo.Stop(); //para de atualizar as label pra aparecer a contagem de strings na tela
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            cfrm.Show(); //mostra o form de config
        }

        private void txtbStrings_TextChanged(object sender, EventArgs e)
        {
            int max = txtbStrings.Lines.Length; //quantidade linhas do textbox que mostra as strings
            if (max > 0) //se tiver mais q 0 linhas
            {
                string ultLinha = txtbStrings.Lines[max - 1]; //pega a ultima linha do textbox
                if (cfrm.txtbBLStr.Text != "") //se o textbox de strings blacklisted nao tiver vazia
                {
                    for (int i = 0; i < cfrm.txtbBLStr.Lines.Length; i++) //pra cada string no textbox de strings blacklisted
                    {
                        if (ultLinha.Contains(cfrm.txtbBLStr.Lines[i])) //compara se nova linha contem alguma das strings blacklisted
                        {
                            //se tiver
                            txtbStrings.Text = txtbStrings.Text.Remove(txtbStrings.Text.LastIndexOf(Environment.NewLine)); //tira ultima linha
                            sdif--; //diminui contagem de strings diferente
                            sbla++; //aumenta contagem de strings blacklisted
                        }
                    }
                }

            }
        }

        private void btTFrm_Click(object sender, EventArgs e)
        {
            txtbT = txtbStrings.Text; //copia o texto da textbox de strings pra uma variavel
            ctmp.Show(); //abre o form temp
            ctmp.updateInfo(); //atualiza a info do form temp
        }

        private void btFile1_Click(object sender, EventArgs e)
        {
            if (coisinhaDeEscolherArquivoLol.ShowDialog() == DialogResult.OK) //se arquivo for escolhido e usuario clicar em ok
            {
                file1 = coisinhaDeEscolherArquivoLol.FileName; //seta a variavel que indica o diretorio com o arquivo de texto escolhido
                f1 = true; //atualiza o bool que indica se arquivo foi setado ou nao
            }
        }

        private void Comparador_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region "timers"
        private void timerInfo_Tick(object sender, EventArgs e)
        {
            updateInfo(); //atualiza a contagem de strings na tela
        }

        private void procInfo_Tick(object sender, EventArgs e)
        {
            var ramAlocada = Process.GetCurrentProcess().WorkingSet64; //pega a ram utilizada pelo aplicativo em bytes
            var ramEmMegabyte = ramAlocada / (1024 * 1024); //converte pra megabytes
            lbRam.Text = "RAM sendo usada: " + ramEmMegabyte + "MB"; //atualiza o texto na tela
        }
        #endregion

        #region "workers"
        private void cTipo2_DoWork(object sender, DoWorkEventArgs e)
        {
            using (FileStream fs = File.Open(file2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) //filestream pra indicar o arquivo de texto e argumentos
            {
                using (BufferedStream bs = new BufferedStream(fs)) //bufferedstream pra nao fuder a memoria ram
                {
                    using (StreamReader sr = new StreamReader(bs)) //streamreader pra ler o arquivo
                    {
                        string line; //declara uma string pra linha
                        while ((line = sr.ReadLine()) != null) //le linha por linha
                        {
                            if (!cTipo2.CancellationPending) //se worker nao tiver em estado de cancelamento
                            {
                                if (ftipo == 2) //se tipo de formatação for 2
                                {
                                    if (line.StartsWith("0x")) //se linha começar com argumento
                                    {
                                        line = line.Substring(line.IndexOf(':') + 2); //tira argumento e deixa só string
                                    }
                                }

                                if (checarCompare(line, ctipo)) //se arquivo sendo comparado tiver string
                                {
                                    stest++; //aumenta a contagem de strings testadas
                                    sigu++; //aumenta a contagem de strings iguais
                                }
                                else
                                {
                                    stest++; //aumenta a contagem de strings testadas
                                    sdif++; //aumenta a contagem de strings diferente
                                    this.Invoke(new MethodInvoker(delegate //invoke porque backgroundworker nao pode atualizar control
                                    {
                                        txtbStrings.AppendText(Environment.NewLine + line); //mostra a string diferente na textbox
                                    }));
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cTipo1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (FileStream fs = File.Open(file1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) //filestream pra indicar o arquivo de texto e argumentos
            {
                using (BufferedStream bs = new BufferedStream(fs)) //bufferedstream pra nao fuder a memoria ram
                {
                    using (StreamReader sr = new StreamReader(bs)) //streamreader pra ler o arquivo
                    {
                        string line; //declara uma string pra linha
                        while ((line = sr.ReadLine()) != null) //le linha por linha
                        {
                            if (!cTipo1.CancellationPending) //se worker nao tiver em estado de cancelamento
                            {
                                if (ftipo == 2) //se tipo de formatação for 2
                                {
                                    if (line.StartsWith("0x")) //se linha começar com argumento
                                    {
                                        line = line.Substring(line.IndexOf(':') + 2); //tira argumento e deixa só string
                                    }
                                }

                                if (checarCompare(line, ctipo)) //se arquivo sendo comparado tiver string
                                {
                                    stest++; //aumenta a contagem de strings testadas
                                    sigu++; //aumenta a contagem de strings iguais
                                }
                                else
                                {
                                    stest++; //aumenta a contagem de strings testadas
                                    sdif++; //aumenta a contagem de strings diferente
                                    this.Invoke(new MethodInvoker(delegate //invoke porque backgroundworker nao pode atualizar control
                                    {
                                        txtbStrings.AppendText(Environment.NewLine + line); //mostra a string diferente na textbox
                                    }));
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
