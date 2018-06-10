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
            this.label1 = new System.Windows.Forms.Label();
            this.lbStest = new System.Windows.Forms.Label();
            this.lbSigu = new System.Windows.Forms.Label();
            this.lbSdif = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.btTrocar = new System.Windows.Forms.Button();
            this.cTipo1 = new System.ComponentModel.BackgroundWorker();
            this.cTipo2 = new System.ComponentModel.BackgroundWorker();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFazendo = new System.Windows.Forms.Label();
            this.lbRam = new System.Windows.Forms.Label();
            this.procInfo = new System.Windows.Forms.Timer(this.components);
            this.btParar = new System.Windows.Forms.Button();
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
            this.txtbStrings.Location = new System.Drawing.Point(33, 357);
            this.txtbStrings.Multiline = true;
            this.txtbStrings.Name = "txtbStrings";
            this.txtbStrings.ReadOnly = true;
            this.txtbStrings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbStrings.Size = new System.Drawing.Size(462, 260);
            this.txtbStrings.TabIndex = 3;
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
            this.panel6.Location = new System.Drawing.Point(12, 329);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 289);
            this.panel6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Strings diferentes";
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
            this.lbSigu.Location = new System.Drawing.Point(23, 91);
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
            this.lbSdif.Location = new System.Drawing.Point(23, 114);
            this.lbSdif.Name = "lbSdif";
            this.lbSdif.Size = new System.Drawing.Size(127, 17);
            this.lbSdif.TabIndex = 11;
            this.lbSdif.Text = "Strings diferentes: ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel7.Location = new System.Drawing.Point(12, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 64);
            this.panel7.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(206, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de compare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comparador";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTipo.ForeColor = System.Drawing.Color.White;
            this.lbTipo.Location = new System.Drawing.Point(133, 204);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(245, 17);
            this.lbTipo.TabIndex = 14;
            this.lbTipo.Text = "Comparando arquivo 1 com arquivo 2";
            // 
            // btTrocar
            // 
            this.btTrocar.Location = new System.Drawing.Point(395, 201);
            this.btTrocar.Name = "btTrocar";
            this.btTrocar.Size = new System.Drawing.Size(63, 25);
            this.btTrocar.TabIndex = 15;
            this.btTrocar.Text = "Trocar";
            this.btTrocar.UseVisualStyleBackColor = true;
            this.btTrocar.Click += new System.EventHandler(this.btTrocar_Click);
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
            this.panel8.Location = new System.Drawing.Point(12, 251);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 64);
            this.panel8.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status";
            // 
            // lbFazendo
            // 
            this.lbFazendo.AutoSize = true;
            this.lbFazendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbFazendo.ForeColor = System.Drawing.Color.White;
            this.lbFazendo.Location = new System.Drawing.Point(36, 281);
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
            this.lbRam.Location = new System.Drawing.Point(300, 281);
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
            this.btParar.Location = new System.Drawing.Point(177, 278);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(51, 25);
            this.btParar.TabIndex = 19;
            this.btParar.Text = "Parar";
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Visible = false;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(507, 628);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.lbRam);
            this.Controls.Add(this.lbFazendo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btTrocar);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btComparar);
            this.Controls.Add(this.btFile2);
            this.Controls.Add(this.btFile1);
            this.Controls.Add(this.lbSdif);
            this.Controls.Add(this.lbSigu);
            this.Controls.Add(this.lbStest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbStrings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Checker";
            this.ShowIcon = false;
            this.Text = "comparador de bosta pelo @poneigc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFile1;
        private System.Windows.Forms.Button btFile2;
        private System.Windows.Forms.Button btComparar;
        private System.Windows.Forms.TextBox txtbStrings;
        private System.Windows.Forms.OpenFileDialog coisinhaDeEscolherArquivoLol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStest;
        private System.Windows.Forms.Label lbSigu;
        private System.Windows.Forms.Label lbSdif;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Button btTrocar;
        private System.ComponentModel.BackgroundWorker cTipo1;
        private System.ComponentModel.BackgroundWorker cTipo2;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFazendo;
        private System.Windows.Forms.Label lbRam;
        private System.Windows.Forms.Timer procInfo;
        private System.Windows.Forms.Button btParar;
    }
}

