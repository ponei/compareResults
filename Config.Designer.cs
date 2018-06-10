namespace compareResults
{
    partial class Config
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
            this.lbTipo = new System.Windows.Forms.Label();
            this.btTrocar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbBLStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btTFormat = new System.Windows.Forms.Button();
            this.lbFormat = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTipo.ForeColor = System.Drawing.Color.White;
            this.lbTipo.Location = new System.Drawing.Point(64, 42);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(245, 17);
            this.lbTipo.TabIndex = 14;
            this.lbTipo.Text = "Comparando arquivo 1 com arquivo 2";
            // 
            // btTrocar
            // 
            this.btTrocar.Location = new System.Drawing.Point(315, 39);
            this.btTrocar.Name = "btTrocar";
            this.btTrocar.Size = new System.Drawing.Size(51, 25);
            this.btTrocar.TabIndex = 20;
            this.btTrocar.Text = "Trocar";
            this.btTrocar.UseVisualStyleBackColor = true;
            this.btTrocar.Click += new System.EventHandler(this.btTrocar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 64);
            this.panel7.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 290);
            this.panel1.TabIndex = 22;
            // 
            // txtbBLStr
            // 
            this.txtbBLStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtbBLStr.Location = new System.Drawing.Point(23, 255);
            this.txtbBLStr.Multiline = true;
            this.txtbBLStr.Name = "txtbBLStr";
            this.txtbBLStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbBLStr.Size = new System.Drawing.Size(390, 207);
            this.txtbBLStr.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Se string diferente estiver blacklisted, ela não conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Coloque uma string por linha";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(16, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(423, 22);
            this.panel9.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(150, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de compare";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 22);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Strings blacklisted";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel3.Location = new System.Drawing.Point(28, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 15);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel4.Location = new System.Drawing.Point(28, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 15);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel5.Location = new System.Drawing.Point(12, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 64);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(16, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(423, 22);
            this.panel6.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Formatação da string";
            // 
            // btTFormat
            // 
            this.btTFormat.Location = new System.Drawing.Point(362, 124);
            this.btTFormat.Name = "btTFormat";
            this.btTFormat.Size = new System.Drawing.Size(51, 25);
            this.btTFormat.TabIndex = 29;
            this.btTFormat.Text = "Trocar";
            this.btTFormat.UseVisualStyleBackColor = true;
            this.btTFormat.Click += new System.EventHandler(this.btTFormat_Click);
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbFormat.ForeColor = System.Drawing.Color.White;
            this.lbFormat.Location = new System.Drawing.Point(33, 126);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(69, 17);
            this.lbFormat.TabIndex = 28;
            this.lbFormat.Text = "Nenhuma";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel8.Location = new System.Drawing.Point(28, 127);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 15);
            this.panel8.TabIndex = 23;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(425, 479);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btTFormat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbFormat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbBLStr);
            this.Controls.Add(this.btTrocar);
            this.Controls.Add(this.lbTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Config";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configuração lol";
            this.Load += new System.EventHandler(this.Config_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Button btTrocar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtbBLStr;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTFormat;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.Panel panel8;
    }
}