namespace compareResults
{
    partial class Comparador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btFile1 = new System.Windows.Forms.Button();
            this.btFile2 = new System.Windows.Forms.Button();
            this.btComparar = new System.Windows.Forms.Button();
            this.txtbStrings = new System.Windows.Forms.TextBox();
            this.coisinhaDeEscolherArquivoLol = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbStest = new System.Windows.Forms.Label();
            this.lbSigu = new System.Windows.Forms.Label();
            this.lbSdif = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btConfig = new System.Windows.Forms.Button();
            this.cTipo1 = new System.ComponentModel.BackgroundWorker();
            this.cTipo2 = new System.ComponentModel.BackgroundWorker();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbFazendo = new System.Windows.Forms.Label();
            this.lbRam = new System.Windows.Forms.Label();
            this.procInfo = new System.Windows.Forms.Timer(this.components);
            this.btParar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSbla = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFile1
            // 
            this.btFile1.Location = new System.Drawing.Point(377, 57);
            this.btFile1.Name = "btFile1";
            this.btFile1.Size = new System.Drawing.Size(118, 34);
            this.btFile1.TabIndex = 0;
            this.btFile1.Text = "Selecionar arquivo 1";
            this.btFile1.UseVisualStyleBackColor = true;
            this.btFile1.Click += new System.EventHandler(this.btFile1_Click);
            // 
            // btFile2
            // 
            this.btFile2.Location = new System.Drawing.Point(377, 96);
            this.btFile2.Name = "btFile2";
            this.btFile2.Size = new System.Drawing.Size(118, 34);
            this.btFile2.TabIndex = 1;
            this.btFile2.Text = "Selecionar arquivo 2";
            this.btFile2.UseVisualStyleBackColor = true;
            this.btFile2.Click += new System.EventHandler(this.btFile2_Click);
            // 
            // btComparar
            // 
            this.btComparar.Location = new System.Drawing.Point(264, 77);
            this.btComparar.Name = "btComparar";
            this.btComparar.Size = new System.Drawing.Size(72, 34);
            this.btComparar.TabIndex = 2;
            this.btComparar.Text = "Comparar";
            this.btComparar.UseVisualStyleBackColor = true;
            this.btComparar.Click += new System.EventHandler(this.btComparar_Click);
            // 
            // txtbStrings
            // 
            this.txtbStrings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtbStrings.Location = new System.Drawing.Point(33, 349);
            this.txtbStrings.Multiline = true;
            this.txtbStrings.Name = "txtbStrings";
            this.txtbStrings.ReadOnly = true;
            this.txtbStrings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbStrings.Size = new System.Drawing.Size(462, 284);
            this.txtbStrings.TabIndex = 3;
            this.txtbStrings.TextChanged += new System.EventHandler(this.txtbStrings_TextChanged);
            // 
            // coisinhaDeEscolherArquivoLol
            // 
            this.coisinhaDeEscolherArquivoLol.Filter = "Results lol (*.txt) | *.txt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 150);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Location = new System.Drawing.Point(334, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 4);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel3.Location = new System.Drawing.Point(353, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 4);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel4.Location = new System.Drawing.Point(353, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 4);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel5.Location = new System.Drawing.Point(353, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 42);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel6.Location = new System.Drawing.Point(12, 321);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 312);
            this.panel6.TabIndex = 5;
            // 
            // lbStest
            // 
            this.lbStest.AutoSize = true;
            this.lbStest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbStest.ForeColor = System.Drawing.Color.White;
            this.lbStest.Location = new System.Drawing.Point(23, 42);
            this.lbStest.Name = "lbStest";
            this.lbStest.Size = new System.Drawing.Size(118, 17);
            this.lbStest.TabIndex = 9;
            this.lbStest.Text = "Strings testadas: ";
            // 
            // lbSigu
            // 
            this.lbSigu.AutoSize = true;
            this.lbSigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbSigu.ForeColor = System.Drawing.Color.White;
            this.lbSigu.Location = new System.Drawing.Point(23, 84);
            this.lbSigu.Name = "lbSigu";
            this.lbSigu.Size = new System.Drawing.Size(101, 17);
            this.lbSigu.TabIndex = 10;
            this.lbSigu.Text = "Strings iguais: ";
            // 
            // lbSdif
            // 
            this.lbSdif.AutoSize = true;
            this.lbSdif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbSdif.ForeColor = System.Drawing.Color.White;
            this.lbSdif.Location = new System.Drawing.Point(23, 107);
            this.lbSdif.Name = "lbSdif";
            this.lbSdif.Size = new System.Drawing.Size(127, 17);
            this.lbSdif.TabIndex = 11;
            this.lbSdif.Text = "Strings diferentes: ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel7.Location = new System.Drawing.Point(12, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 50);
            this.panel7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(205, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comparador";
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(181, 202);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(170, 26);
            this.btConfig.TabIndex = 15;
            this.btConfig.Text = "Abrir aba de configuração";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // cTipo1
            // 
            this.cTipo1.WorkerSupportsCancellation = true;
            this.cTipo1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cTipo1_DoWork);
            // 
            // cTipo2
            // 
            this.cTipo2.WorkerSupportsCancellation = true;
            this.cTipo2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cTipo2_DoWork);
            // 
            // timerInfo
            // 
            this.timerInfo.Interval = 1000;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel8.Location = new System.Drawing.Point(12, 243);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 64);
            this.panel8.TabIndex = 6;
            // 
            // lbFazendo
            // 
            this.lbFazendo.AutoSize = true;
            this.lbFazendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbFazendo.ForeColor = System.Drawing.Color.White;
            this.lbFazendo.Location = new System.Drawing.Point(33, 277);
            this.lbFazendo.Name = "lbFazendo";
            this.lbFazendo.Size = new System.Drawing.Size(105, 17);
            this.lbFazendo.TabIndex = 17;
            this.lbFazendo.Text = "Fazendo: Nada";
            // 
            // lbRam
            // 
            this.lbRam.AutoSize = true;
            this.lbRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbRam.ForeColor = System.Drawing.Color.White;
            this.lbRam.Location = new System.Drawing.Point(300, 277);
            this.lbRam.Name = "lbRam";
            this.lbRam.Size = new System.Drawing.Size(132, 17);
            this.lbRam.TabIndex = 18;
            this.lbRam.Text = "RAM sendo usada: ";
            // 
            // procInfo
            // 
            this.procInfo.Enabled = true;
            this.procInfo.Interval = 1000;
            this.procInfo.Tick += new System.EventHandler(this.procInfo_Tick);
            // 
            // btParar
            // 
            this.btParar.Location = new System.Drawing.Point(177, 274);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(51, 25);
            this.btParar.TabIndex = 19;
            this.btParar.Text = "Parar";
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Visible = false;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(16, 13);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(501, 22);
            this.panel9.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(16, 178);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(501, 22);
            this.panel10.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Configuração";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel11.Controls.Add(this.label4);
            this.panel11.Location = new System.Drawing.Point(16, 243);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(501, 22);
            this.panel11.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel12.Controls.Add(this.label2);
            this.panel12.Location = new System.Drawing.Point(16, 321);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(501, 22);
            this.panel12.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Strings diferentes";
            // 
            // lbSbla
            // 
            this.lbSbla.AutoSize = true;
            this.lbSbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbSbla.ForeColor = System.Drawing.Color.White;
            this.lbSbla.Location = new System.Drawing.Point(23, 130);
            this.lbSbla.Name = "lbSbla";
            this.lbSbla.Size = new System.Drawing.Size(137, 17);
            this.lbSbla.TabIndex = 23;
            this.lbSbla.Text = "Strings blacklisteds: ";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel13.Location = new System.Drawing.Point(29, 279);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(4, 15);
            this.panel13.TabIndex = 24;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel14.Location = new System.Drawing.Point(296, 279);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(4, 15);
            this.panel14.TabIndex = 25;
            // 
            // Comparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(507, 645);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.lbSbla);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.lbRam);
            this.Controls.Add(this.lbFazendo);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.btComparar);
            this.Controls.Add(this.btFile2);
            this.Controls.Add(this.btFile1);
            this.Controls.Add(this.lbSdif);
            this.Controls.Add(this.lbSigu);
            this.Controls.Add(this.lbStest);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtbStrings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Comparador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "comparador de bosta pelo @poneigc";
            this.Load += new System.EventHandler(this.Comparador_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFile1;
        private System.Windows.Forms.Button btFile2;
        private System.Windows.Forms.Button btComparar;
        private System.Windows.Forms.OpenFileDialog coisinhaDeEscolherArquivoLol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbStest;
        private System.Windows.Forms.Label lbSigu;
        private System.Windows.Forms.Label lbSdif;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btConfig;
        private System.ComponentModel.BackgroundWorker cTipo1;
        private System.ComponentModel.BackgroundWorker cTipo2;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbFazendo;
        private System.Windows.Forms.Label lbRam;
        private System.Windows.Forms.Timer procInfo;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSbla;
        private System.Windows.Forms.TextBox txtbStrings;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
    }
}

