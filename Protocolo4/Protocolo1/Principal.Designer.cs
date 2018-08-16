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
            this.lblIP = new System.Windows.Forms.Label();
            this.txtbIP = new System.Windows.Forms.TextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.txtbResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cbCoS = new System.Windows.Forms.ComboBox();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.btnCargarLlaves = new System.Windows.Forms.Button();
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
            this.lblCoS.Size = new System.Drawing.Size(117, 13);
            this.lblCoS.TabIndex = 1;
            this.lblCoS.Text = "¿Quien eres? (telefono)";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(23, 119);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(81, 13);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP del contrario:";
            // 
            // txtbIP
            // 
            this.txtbIP.Location = new System.Drawing.Point(26, 135);
            this.txtbIP.Name = "txtbIP";
            this.txtbIP.Size = new System.Drawing.Size(153, 20);
            this.txtbIP.TabIndex = 4;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackgroundImage = global::Protocolo1.Properties.Resources.play;
            this.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpezar.Location = new System.Drawing.Point(273, 108);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(47, 47);
            this.btnEmpezar.TabIndex = 5;
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // txtbResultado
            // 
            this.txtbResultado.Location = new System.Drawing.Point(26, 400);
            this.txtbResultado.Multiline = true;
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.Size = new System.Drawing.Size(326, 83);
            this.txtbResultado.TabIndex = 19;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(23, 384);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "Resultado";
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(210, 46);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(153, 20);
            this.txtbTelefono.TabIndex = 21;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(207, 20);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(113, 13);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Telefono del contrario:";
            // 
            // cbCoS
            // 
            this.cbCoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoS.FormattingEnabled = true;
            this.cbCoS.Items.AddRange(new object[] {
            "Emisor",
            "Receptor"});
            this.cbCoS.Location = new System.Drawing.Point(26, 45);
            this.cbCoS.Name = "cbCoS";
            this.cbCoS.Size = new System.Drawing.Size(153, 21);
            this.cbCoS.TabIndex = 2;
            // 
            // btnCargarLlaves
            // 
            this.btnCargarLlaves.Location = new System.Drawing.Point(26, 83);
            this.btnCargarLlaves.Name = "btnCargarLlaves";
            this.btnCargarLlaves.Size = new System.Drawing.Size(153, 23);
            this.btnCargarLlaves.TabIndex = 22;
            this.btnCargarLlaves.Text = "Cargar llaves";
            this.btnCargarLlaves.UseVisualStyleBackColor = true;
            this.btnCargarLlaves.Click += new System.EventHandler(this.btnCargarLlaves_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 498);
            this.Controls.Add(this.btnCargarLlaves);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtbResultado);
            this.Controls.Add(this.lblResultado);
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
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtbIP;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lblRContador3;
        private System.Windows.Forms.Label lblRContador2;
        private System.Windows.Forms.Label lblRContador1;
        private System.Windows.Forms.Label lblContador3;
        private System.Windows.Forms.Label lblContador2;
        private System.Windows.Forms.Label lblContador1;
        private System.Windows.Forms.TextBox txtbResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cbCoS;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.Button btnCargarLlaves;
    }
}