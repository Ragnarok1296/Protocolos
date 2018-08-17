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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.gbTiempos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
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
            this.gbTiempos.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiempos.Location = new System.Drawing.Point(29, 219);
            this.gbTiempos.Name = "gbTiempos";
            this.gbTiempos.Size = new System.Drawing.Size(326, 158);
            this.gbTiempos.TabIndex = 0;
            this.gbTiempos.TabStop = false;
            this.gbTiempos.Text = "Tiempos";
            // 
            // lblRContador3
            // 
            this.lblRContador3.AutoSize = true;
            this.lblRContador3.Location = new System.Drawing.Point(181, 117);
            this.lblRContador3.Name = "lblRContador3";
            this.lblRContador3.Size = new System.Drawing.Size(0, 16);
            this.lblRContador3.TabIndex = 5;
            // 
            // lblRContador2
            // 
            this.lblRContador2.AutoSize = true;
            this.lblRContador2.Location = new System.Drawing.Point(181, 81);
            this.lblRContador2.Name = "lblRContador2";
            this.lblRContador2.Size = new System.Drawing.Size(0, 16);
            this.lblRContador2.TabIndex = 4;
            // 
            // lblRContador1
            // 
            this.lblRContador1.AutoSize = true;
            this.lblRContador1.Location = new System.Drawing.Point(181, 44);
            this.lblRContador1.Name = "lblRContador1";
            this.lblRContador1.Size = new System.Drawing.Size(0, 16);
            this.lblRContador1.TabIndex = 3;
            // 
            // lblContador3
            // 
            this.lblContador3.AutoSize = true;
            this.lblContador3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador3.Location = new System.Drawing.Point(27, 117);
            this.lblContador3.Name = "lblContador3";
            this.lblContador3.Size = new System.Drawing.Size(91, 16);
            this.lblContador3.TabIndex = 2;
            this.lblContador3.Text = "Tiempo total :";
            // 
            // lblContador2
            // 
            this.lblContador2.AutoSize = true;
            this.lblContador2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador2.Location = new System.Drawing.Point(27, 81);
            this.lblContador2.Name = "lblContador2";
            this.lblContador2.Size = new System.Drawing.Size(102, 16);
            this.lblContador2.TabIndex = 1;
            this.lblContador2.Text = "Envio de datos: ";
            // 
            // lblContador1
            // 
            this.lblContador1.AutoSize = true;
            this.lblContador1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador1.Location = new System.Drawing.Point(27, 44);
            this.lblContador1.Name = "lblContador1";
            this.lblContador1.Size = new System.Drawing.Size(156, 16);
            this.lblContador1.TabIndex = 0;
            this.lblContador1.Text = "Generacion de numeros: ";
            // 
            // lblCoS
            // 
            this.lblCoS.AutoSize = true;
            this.lblCoS.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoS.Location = new System.Drawing.Point(21, 61);
            this.lblCoS.Name = "lblCoS";
            this.lblCoS.Size = new System.Drawing.Size(141, 16);
            this.lblCoS.TabIndex = 1;
            this.lblCoS.Text = "¿Quien eres? (telefono)";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(21, 162);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(105, 16);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP del contrario:";
            // 
            // txtbIP
            // 
            this.txtbIP.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbIP.Location = new System.Drawing.Point(24, 178);
            this.txtbIP.Name = "txtbIP";
            this.txtbIP.Size = new System.Drawing.Size(153, 23);
            this.txtbIP.TabIndex = 4;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmpezar.BackgroundImage = global::Protocolo1.Properties.Resources.play;
            this.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.ForeColor = System.Drawing.Color.Black;
            this.btnEmpezar.Location = new System.Drawing.Point(264, 154);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(47, 47);
            this.btnEmpezar.TabIndex = 5;
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // txtbResultado
            // 
            this.txtbResultado.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbResultado.Location = new System.Drawing.Point(29, 413);
            this.txtbResultado.Multiline = true;
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.Size = new System.Drawing.Size(326, 83);
            this.txtbResultado.TabIndex = 19;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(26, 394);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(66, 16);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "Resultado";
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTelefono.Location = new System.Drawing.Point(208, 89);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(153, 23);
            this.txtbTelefono.TabIndex = 21;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(205, 63);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(140, 16);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Telefono del contrario:";
            // 
            // cbCoS
            // 
            this.cbCoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoS.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCoS.FormattingEnabled = true;
            this.cbCoS.Items.AddRange(new object[] {
            "Emisor",
            "Receptor"});
            this.cbCoS.Location = new System.Drawing.Point(24, 88);
            this.cbCoS.Name = "cbCoS";
            this.cbCoS.Size = new System.Drawing.Size(153, 24);
            this.cbCoS.TabIndex = 2;
            // 
            // btnCargarLlaves
            // 
            this.btnCargarLlaves.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargarLlaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarLlaves.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLlaves.Location = new System.Drawing.Point(24, 126);
            this.btnCargarLlaves.Name = "btnCargarLlaves";
            this.btnCargarLlaves.Size = new System.Drawing.Size(153, 25);
            this.btnCargarLlaves.TabIndex = 22;
            this.btnCargarLlaves.Text = "Cargar llaves";
            this.btnCargarLlaves.UseVisualStyleBackColor = false;
            this.btnCargarLlaves.Click += new System.EventHandler(this.btnCargarLlaves_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 50);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbxCerrar.Image")));
            this.pbxCerrar.Location = new System.Drawing.Point(333, 5);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(40, 40);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrar.TabIndex = 26;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 513);
            this.Controls.Add(this.pbxCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protocolo Basico";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.gbTiempos.ResumeLayout(false);
            this.gbTiempos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCerrar;
    }
}