namespace Subida_FACe1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btBuscarCertificado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRutaCertificado = new System.Windows.Forms.TextBox();
            this.btBuscarFacturas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCarpetaFacturas = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContrasenaCertificado = new System.Windows.Forms.TextBox();
            this.btSubir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvResultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.Resultado});
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultado.Location = new System.Drawing.Point(2, 20);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(591, 390);
            this.dgvResultado.TabIndex = 1;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 76;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Width = 89;
            // 
            // btExportar
            // 
            this.btExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExportar.BackgroundImage")));
            this.btExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.ForeColor = System.Drawing.Color.White;
            this.btExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExportar.Location = new System.Drawing.Point(319, 159);
            this.btExportar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(280, 50);
            this.btExportar.TabIndex = 3;
            this.btExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExportar.UseVisualStyleBackColor = false;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvResultado);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(595, 413);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado Subida";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(582, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(186, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subida Masiva FACe";
            // 
            // btBuscarCertificado
            // 
            this.btBuscarCertificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btBuscarCertificado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btBuscarCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarCertificado.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarCertificado.ForeColor = System.Drawing.Color.White;
            this.btBuscarCertificado.Location = new System.Drawing.Point(543, 72);
            this.btBuscarCertificado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBuscarCertificado.Name = "btBuscarCertificado";
            this.btBuscarCertificado.Size = new System.Drawing.Size(56, 23);
            this.btBuscarCertificado.TabIndex = 19;
            this.btBuscarCertificado.Text = "Buscar";
            this.btBuscarCertificado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBuscarCertificado.UseVisualStyleBackColor = false;
            this.btBuscarCertificado.Click += new System.EventHandler(this.btBuscarCertificado_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(3, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Carpeta facturas";
            // 
            // tbRutaCertificado
            // 
            this.tbRutaCertificado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRutaCertificado.Location = new System.Drawing.Point(144, 72);
            this.tbRutaCertificado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbRutaCertificado.Multiline = true;
            this.tbRutaCertificado.Name = "tbRutaCertificado";
            this.tbRutaCertificado.Size = new System.Drawing.Size(395, 23);
            this.tbRutaCertificado.TabIndex = 16;
            // 
            // btBuscarFacturas
            // 
            this.btBuscarFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btBuscarFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btBuscarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarFacturas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarFacturas.ForeColor = System.Drawing.Color.White;
            this.btBuscarFacturas.Location = new System.Drawing.Point(543, 43);
            this.btBuscarFacturas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBuscarFacturas.Name = "btBuscarFacturas";
            this.btBuscarFacturas.Size = new System.Drawing.Size(56, 23);
            this.btBuscarFacturas.TabIndex = 18;
            this.btBuscarFacturas.Text = "Buscar";
            this.btBuscarFacturas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBuscarFacturas.UseVisualStyleBackColor = false;
            this.btBuscarFacturas.Click += new System.EventHandler(this.btBuscarFacturas_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ruta Certificado";
            // 
            // tbCarpetaFacturas
            // 
            this.tbCarpetaFacturas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCarpetaFacturas.Location = new System.Drawing.Point(144, 43);
            this.tbCarpetaFacturas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbCarpetaFacturas.Multiline = true;
            this.tbCarpetaFacturas.Name = "tbCarpetaFacturas";
            this.tbCarpetaFacturas.Size = new System.Drawing.Size(395, 23);
            this.tbCarpetaFacturas.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.Location = new System.Drawing.Point(144, 130);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(455, 23);
            this.tbEmail.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(4, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña Certificado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(4, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email notificaciones";
            // 
            // tbContrasenaCertificado
            // 
            this.tbContrasenaCertificado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbContrasenaCertificado.Location = new System.Drawing.Point(144, 101);
            this.tbContrasenaCertificado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbContrasenaCertificado.Multiline = true;
            this.tbContrasenaCertificado.Name = "tbContrasenaCertificado";
            this.tbContrasenaCertificado.PasswordChar = '*';
            this.tbContrasenaCertificado.Size = new System.Drawing.Size(455, 23);
            this.tbContrasenaCertificado.TabIndex = 17;
            // 
            // btSubir
            // 
            this.btSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btSubir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubir.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubir.ForeColor = System.Drawing.Color.White;
            this.btSubir.Location = new System.Drawing.Point(6, 159);
            this.btSubir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSubir.Name = "btSubir";
            this.btSubir.Size = new System.Drawing.Size(280, 50);
            this.btSubir.TabIndex = 21;
            this.btSubir.Text = "Subir a FACe";
            this.btSubir.UseVisualStyleBackColor = false;
            this.btSubir.Click += new System.EventHandler(this.btSubir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 35);
            this.panel1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 640);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSubir);
            this.Controls.Add(this.btBuscarCertificado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRutaCertificado);
            this.Controls.Add(this.btBuscarFacturas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbCarpetaFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbContrasenaCertificado);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subida Masiva FACe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBuscarCertificado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRutaCertificado;
        private System.Windows.Forms.Button btBuscarFacturas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCarpetaFacturas;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContrasenaCertificado;
        private System.Windows.Forms.Button btSubir;
        private System.Windows.Forms.Panel panel1;
    }
}

