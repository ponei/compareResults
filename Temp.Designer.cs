namespace compareResults
{
    partial class Temp
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
            this.txtbTemp = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lbTempo = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbTemp
            // 
            this.txtbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtbTemp.Location = new System.Drawing.Point(28, 80);
            this.txtbTemp.Multiline = true;
            this.txtbTemp.Name = "txtbTemp";
            this.txtbTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbTemp.Size = new System.Drawing.Size(456, 287);
            this.txtbTemp.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 357);
            this.panel6.TabIndex = 23;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel12.Controls.Add(this.label2);
            this.panel12.Location = new System.Drawing.Point(16, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(501, 22);
            this.panel12.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Caixa de texto temporária";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel13.Location = new System.Drawing.Point(37, 50);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(4, 15);
            this.panel13.TabIndex = 26;
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTempo.ForeColor = System.Drawing.Color.White;
            this.lbTempo.Location = new System.Drawing.Point(41, 48);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(215, 17);
            this.lbTempo.TabIndex = 25;
            this.lbTempo.Text = "Última cópia temporária feita em:";
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(496, 379);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtbTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Temp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "temp lol";
            this.Load += new System.EventHandler(this.Temp_Load);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbTemp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lbTempo;
    }
}