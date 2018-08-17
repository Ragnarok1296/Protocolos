namespace Protocolo1
{
    partial class Principal
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
            this.gbTiempos = new System.Windows.Forms.GroupBox();
            this.lblRContador3 = new System.Windows.Forms.Label();
            this.lblRContador2 = new System.Windows.Forms.Label();
            this.lblRContador1 = new System.Windows.Forms.Label();
            this.lblContador3 = new System.Windows.Forms.Label();
            this.lblContador2 = new System.Windows.Forms.Label();
            this.lblContador1 = new System.Windows.Forms.Label();
            this.lblCoS = new System.Windows.Forms.Label();
            this.cbCoS = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtbIP = new System.Windows.Forms.TextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lblBits = new System.Windows.Forms.Label();
            this.cbBits = new System.Windows.Forms.ComboBox();
            this.txtbNa = new System.Windows.Forms.TextBox();
            this.txtbN = new System.Windows.Forms.TextBox();
            this.txtbKaKb = new System.Windows.Forms.TextBox();
            this.txtbKaKbInv = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblKaKb = new System.Windows.Forms.Label();
            this.lblNa = new System.Windows.Forms.Label();
            this.lblKaKbInv = new System.Windows.Forms.Label();
            this.lblCanal1 = new System.Windows.Forms.Label();
            this.txtbCanal1 = new System.Windows.Forms.TextBox();
            this.txtbCanal2 = new System.Windows.Forms.TextBox();
            this.lblCanal2 = new System.Windows.Forms.Label();
            this.txtbCanal3 = new System.Windows.Forms.TextBox();
            this.lblCanal3 = new System.Windows.Forms.Label();
            this.txtCanal21 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaNb = new System.Windows.Forms.Label();
            this.txtbNaNb = new System.Windows.Forms.TextBox();
            this.gbTiempos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTiempos
            // 
            this.gbTiempos.Controls.Add(this.lblRContador3);
            this.gbTiempos.Controls.Add(this.lblRContador2);
            this.gbTiempos.Controls.Add(this.lblRContador1);
            this.gbTiempos.Controls.Add(this.lblContador3);
            this.gbTiempos.Controls.Add(this.lblContador2);
            this.gbTiempos.Controls.Add(this.lblContador1);
            this.gbTiempos.Location = new System.Drawing.Point(26, 165);
            this.gbTiempos.Name = "gbTiempos";
            this.gbTiempos.Size = new System.Drawing.Size(326, 197);
            this.gbTiempos.TabIndex = 0;
            this.gbTiempos.TabStop = false;
            this.gbTiempos.Text = "Tiempos";
            // 
            // lblRContador3
            // 
            this.lblRContador3.AutoSize = true;
            this.lblRContador3.Location = new System.Drawing.Point(181, 117);
            this.lblRContador3.Name = "lblRContador3";
            this.lblRContador3.Size = new System.Drawing.Size(0, 13);
            this.lblRContador3.TabIndex = 5;
            // 
            // lblRContador2
            // 
            this.lblRContador2.AutoSize = true;
            this.lblRContador2.Location = new System.Drawing.Point(181, 81);
            this.lblRContador2.Name = "lblRContador2";
            this.lblRContador2.Size = new System.Drawing.Size(0, 13);
            this.lblRContador2.TabIndex = 4;
            // 
            // lblRContador1
            // 
            this.lblRContador1.AutoSize = true;
            this.lblRContador1.Location = new System.Drawing.Point(181, 44);
            this.lblRContador1.Name = "lblRContador1";
            this.lblRContador1.Size = new System.Drawing.Size(0, 13);
            this.lblRContador1.TabIndex = 3;
            // 
            // lblContador3
            // 
            this.lblContador3.AutoSize = true;
            this.lblContador3.Location = new System.Drawing.Point(27, 117);
            this.lblContador3.Name = "lblContador3";
            this.lblContador3.Size = new System.Drawing.Size(71, 13);
            this.lblContador3.TabIndex = 2;
            this.lblContador3.Text = "Tiempo total :";
            // 
            // lblContador2
            // 
            this.lblContador2.AutoSize = true;
            this.lblContador2.Location = new System.Drawing.Point(27, 81);
            this.lblContador2.Name = "lblContador2";
            this.lblContador2.Size = new System.Drawing.Size(84, 13);
            this.lblContador2.TabIndex = 1;
            this.lblContador2.Text = "Envio de datos: ";
            // 
            // lblContador1
            // 
            this.lblContador1.AutoSize = true;
            this.lblContador1.Location = new System.Drawing.Point(27, 44);
            this.lblContador1.Name = "lblContador1";
            this.lblContador1.Size = new System.Drawing.Size(126, 13);
            this.lblContador1.TabIndex = 0;
            this.lblContador1.Text = "Generacion de numeros: ";
            // 
            // lblCoS
            // 
            this.lblCoS.AutoSize = true;
            this.lblCoS.Location = new System.Drawing.Point(23, 18);
            this.lblCoS.Name = "lblCoS";
            this.lblCoS.Size = new System.Drawing.Size(70, 13);
            this.lblCoS.TabIndex = 1;
            this.lblCoS.Text = "¿Quien eres?";
            // 
            // cbCoS
            // 
            this.cbCoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoS.FormattingEnabled = true;
            this.cbCoS.Items.AddRange(new object[] {
            "Alice",
            "Bob"});
            this.cbCoS.Location = new System.Drawing.Point(26, 45);
            this.cbCoS.Name = "cbCoS";
            this.cbCoS.Size = new System.Drawing.Size(153, 21);
            this.cbCoS.TabIndex = 2;
            this.cbCoS.SelectedIndexChanged += new System.EventHandler(this.cbCoS_SelectedIndexChanged);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(23, 85);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(35, 13);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP de:";
            this.lblIP.Visible = false;
            // 
            // txtbIP
            // 
            this.txtbIP.Location = new System.Drawing.Point(26, 111);
            this.txtbIP.Name = "txtbIP";
            this.txtbIP.Size = new System.Drawing.Size(153, 20);
            this.txtbIP.TabIndex = 4;
            this.txtbIP.Visible = false;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackgroundImage = global::Protocolo1.Properties.Resources.play;
            this.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpezar.Location = new System.Drawing.Point(256, 97);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(47, 47);
            this.btnEmpezar.TabIndex = 5;
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Visible = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(207, 18);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(77, 13);
            this.lblBits.TabIndex = 6;
            this.lblBits.Text = "¿Cuantos bits?";
            // 
            // cbBits
            // 
            this.cbBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBits.FormattingEnabled = true;
            this.cbBits.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512"});
            this.cbBits.Location = new System.Drawing.Point(210, 45);
            this.cbBits.Name = "cbBits";
            this.cbBits.Size = new System.Drawing.Size(142, 21);
            this.cbBits.TabIndex = 7;
            // 
            // txtbNa
            // 
            this.txtbNa.Location = new System.Drawing.Point(385, 309);
            this.txtbNa.Multiline = true;
            this.txtbNa.Name = "txtbNa";
            this.txtbNa.Size = new System.Drawing.Size(295, 53);
            this.txtbNa.TabIndex = 8;
            // 
            // txtbN
            // 
            this.txtbN.Location = new System.Drawing.Point(385, 34);
            this.txtbN.Multiline = true;
            this.txtbN.Name = "txtbN";
            this.txtbN.Size = new System.Drawing.Size(295, 53);
            this.txtbN.TabIndex = 9;
            // 
            // txtbKaKb
            // 
            this.txtbKaKb.Location = new System.Drawing.Point(385, 127);
            this.txtbKaKb.Multiline = true;
            this.txtbKaKb.Name = "txtbKaKb";
            this.txtbKaKb.Size = new System.Drawing.Size(295, 53);
            this.txtbKaKb.TabIndex = 10;
            // 
            // txtbKaKbInv
            // 
            this.txtbKaKbInv.Location = new System.Drawing.Point(385, 215);
            this.txtbKaKbInv.Multiline = true;
            this.txtbKaKbInv.Name = "txtbKaKbInv";
            this.txtbKaKbInv.Size = new System.Drawing.Size(295, 53);
            this.txtbKaKbInv.TabIndex = 11;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(382, 18);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 12;
            this.lblN.Text = "N";
            // 
            // lblKaKb
            // 
            this.lblKaKb.AutoSize = true;
            this.lblKaKb.Location = new System.Drawing.Point(382, 111);
            this.lblKaKb.Name = "lblKaKb";
            this.lblKaKb.Size = new System.Drawing.Size(45, 13);
            this.lblKaKb.TabIndex = 13;
            this.lblKaKb.Text = "Ka o Kb";
            // 
            // lblNa
            // 
            this.lblNa.AutoSize = true;
            this.lblNa.Location = new System.Drawing.Point(382, 293);
            this.lblNa.Name = "lblNa";
            this.lblNa.Size = new System.Drawing.Size(21, 13);
            this.lblNa.TabIndex = 14;
            this.lblNa.Text = "Na";
            // 
            // lblKaKbInv
            // 
            this.lblKaKbInv.AutoSize = true;
            this.lblKaKbInv.Location = new System.Drawing.Point(382, 199);
            this.lblKaKbInv.Name = "lblKaKbInv";
            this.lblKaKbInv.Size = new System.Drawing.Size(82, 13);
            this.lblKaKbInv.TabIndex = 15;
            this.lblKaKbInv.Text = "Ka o Kb inversa";
            // 
            // lblCanal1
            // 
            this.lblCanal1.AutoSize = true;
            this.lblCanal1.Location = new System.Drawing.Point(708, 18);
            this.lblCanal1.Name = "lblCanal1";
            this.lblCanal1.Size = new System.Drawing.Size(43, 13);
            this.lblCanal1.TabIndex = 16;
            this.lblCanal1.Text = "Canal 1";
            // 
            // txtbCanal1
            // 
            this.txtbCanal1.Location = new System.Drawing.Point(711, 34);
            this.txtbCanal1.Multiline = true;
            this.txtbCanal1.Name = "txtbCanal1";
            this.txtbCanal1.Size = new System.Drawing.Size(295, 53);
            this.txtbCanal1.TabIndex = 17;
            // 
            // txtbCanal2
            // 
            this.txtbCanal2.Location = new System.Drawing.Point(711, 127);
            this.txtbCanal2.Multiline = true;
            this.txtbCanal2.Name = "txtbCanal2";
            this.txtbCanal2.Size = new System.Drawing.Size(295, 53);
            this.txtbCanal2.TabIndex = 19;
            // 
            // lblCanal2
            // 
            this.lblCanal2.AutoSize = true;
            this.lblCanal2.Location = new System.Drawing.Point(708, 111);
            this.lblCanal2.Name = "lblCanal2";
            this.lblCanal2.Size = new System.Drawing.Size(58, 13);
            this.lblCanal2.TabIndex = 18;
            this.lblCanal2.Text = "Canal 2 (1)";
            // 
            // txtbCanal3
            // 
            this.txtbCanal3.Location = new System.Drawing.Point(711, 309);
            this.txtbCanal3.Multiline = true;
            this.txtbCanal3.Name = "txtbCanal3";
            this.txtbCanal3.Size = new System.Drawing.Size(295, 53);
            this.txtbCanal3.TabIndex = 21;
            // 
            // lblCanal3
            // 
            this.lblCanal3.AutoSize = true;
            this.lblCanal3.Location = new System.Drawing.Point(708, 293);
            this.lblCanal3.Name = "lblCanal3";
            this.lblCanal3.Size = new System.Drawing.Size(43, 13);
            this.lblCanal3.TabIndex = 20;
            this.lblCanal3.Text = "Canal 3";
            // 
            // txtCanal21
            // 
            this.txtCanal21.Location = new System.Drawing.Point(711, 215);
            this.txtCanal21.Multiline = true;
            this.txtCanal21.Name = "txtCanal21";
            this.txtCanal21.Size = new System.Drawing.Size(295, 53);
            this.txtCanal21.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Canal 2 (2)";
            // 
            // lblNaNb
            // 
            this.lblNaNb.AutoSize = true;
            this.lblNaNb.Location = new System.Drawing.Point(382, 370);
            this.lblNaNb.Name = "lblNaNb";
            this.lblNaNb.Size = new System.Drawing.Size(39, 13);
            this.lblNaNb.TabIndex = 25;
            this.lblNaNb.Text = "Na*Nb";
            // 
            // txtbNaNb
            // 
            this.txtbNaNb.Location = new System.Drawing.Point(385, 386);
            this.txtbNaNb.Multiline = true;
            this.txtbNaNb.Name = "txtbNaNb";
            this.txtbNaNb.Size = new System.Drawing.Size(295, 53);
            this.txtbNaNb.TabIndex = 24;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 446);
            this.Controls.Add(this.lblNaNb);
            this.Controls.Add(this.txtbNaNb);
            this.Controls.Add(this.txtCanal21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbCanal3);
            this.Controls.Add(this.lblCanal3);
            this.Controls.Add(this.txtbCanal2);
            this.Controls.Add(this.lblCanal2);
            this.Controls.Add(this.txtbCanal1);
            this.Controls.Add(this.lblCanal1);
            this.Controls.Add(this.lblKaKbInv);
            this.Controls.Add(this.lblNa);
            this.Controls.Add(this.lblKaKb);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtbKaKbInv);
            this.Controls.Add(this.txtbKaKb);
            this.Controls.Add(this.txtbNa);
            this.Controls.Add(this.txtbN);
            this.Controls.Add(this.cbBits);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.txtbIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.cbCoS);
            this.Controls.Add(this.lblCoS);
            this.Controls.Add(this.gbTiempos);
            this.Name = "Principal";
            this.Text = "Protocolo Basico";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.gbTiempos.ResumeLayout(false);
            this.gbTiempos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTiempos;
        private System.Windows.Forms.Label lblCoS;
        private System.Windows.Forms.ComboBox cbCoS;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtbIP;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lblRContador3;
        private System.Windows.Forms.Label lblRContador2;
        private System.Windows.Forms.Label lblRContador1;
        private System.Windows.Forms.Label lblContador3;
        private System.Windows.Forms.Label lblContador2;
        private System.Windows.Forms.Label lblContador1;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ComboBox cbBits;
        private System.Windows.Forms.TextBox txtbNa;
        private System.Windows.Forms.TextBox txtbN;
        private System.Windows.Forms.TextBox txtbKaKb;
        private System.Windows.Forms.TextBox txtbKaKbInv;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblKaKb;
        private System.Windows.Forms.Label lblNa;
        private System.Windows.Forms.Label lblKaKbInv;
        private System.Windows.Forms.Label lblCanal1;
        private System.Windows.Forms.TextBox txtbCanal1;
        private System.Windows.Forms.TextBox txtbCanal2;
        private System.Windows.Forms.Label lblCanal2;
        private System.Windows.Forms.TextBox txtbCanal3;
        private System.Windows.Forms.Label lblCanal3;
        private System.Windows.Forms.TextBox txtCanal21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaNb;
        private System.Windows.Forms.TextBox txtbNaNb;
    }
}