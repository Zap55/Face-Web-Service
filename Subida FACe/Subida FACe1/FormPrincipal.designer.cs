namespace Pruebas_diseño
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcel = new System.Windows.Forms.PictureBox();
            this.btConfiguracion = new System.Windows.Forms.Button();
            this.btEstado = new System.Windows.Forms.Button();
            this.btAnular = new System.Windows.Forms.Button();
            this.btSubir = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btExcel);
            this.panel1.Controls.Add(this.btConfiguracion);
            this.panel1.Controls.Add(this.btEstado);
            this.panel1.Controls.Add(this.btAnular);
            this.panel1.Controls.Add(this.btSubir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subida FACe";
            // 
            // btExcel
            // 
            this.btExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcel.Image = ((System.Drawing.Image)(resources.GetObject("btExcel.Image")));
            this.btExcel.Location = new System.Drawing.Point(0, 387);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(170, 60);
            this.btExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btExcel.TabIndex = 4;
            this.btExcel.TabStop = false;
            // 
            // btConfiguracion
            // 
            this.btConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.btConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfiguracion.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btConfiguracion.Location = new System.Drawing.Point(0, 249);
            this.btConfiguracion.Name = "btConfiguracion";
            this.btConfiguracion.Size = new System.Drawing.Size(170, 35);
            this.btConfiguracion.TabIndex = 4;
            this.btConfiguracion.Text = "Configuración";
            this.btConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btEstado
            // 
            this.btEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.btEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstado.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstado.ForeColor = System.Drawing.Color.White;
            this.btEstado.Location = new System.Drawing.Point(0, 208);
            this.btEstado.Name = "btEstado";
            this.btEstado.Size = new System.Drawing.Size(170, 35);
            this.btEstado.TabIndex = 3;
            this.btEstado.Text = "Estado";
            this.btEstado.UseVisualStyleBackColor = true;
            // 
            // btAnular
            // 
            this.btAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.btAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnular.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnular.ForeColor = System.Drawing.Color.White;
            this.btAnular.Location = new System.Drawing.Point(0, 167);
            this.btAnular.Name = "btAnular";
            this.btAnular.Size = new System.Drawing.Size(170, 35);
            this.btAnular.TabIndex = 2;
            this.btAnular.Text = "Anular";
            this.btAnular.UseVisualStyleBackColor = true;
            // 
            // btSubir
            // 
            this.btSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.btSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubir.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubir.ForeColor = System.Drawing.Color.White;
            this.btSubir.Location = new System.Drawing.Point(0, 126);
            this.btSubir.Name = "btSubir";
            this.btSubir.Size = new System.Drawing.Size(170, 35);
            this.btSubir.TabIndex = 1;
            this.btSubir.Text = "Subir";
            this.btSubir.UseVisualStyleBackColor = true;
            this.btSubir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btCerrar.Image")));
            this.btCerrar.Location = new System.Drawing.Point(879, 3);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(18, 18);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 4;
            this.btCerrar.TabStop = false;
            this.btCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.btCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 25);
            this.panel2.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContenedor.Location = new System.Drawing.Point(172, 25);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(728, 425);
            this.panelContenedor.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSubir;
        private System.Windows.Forms.Button btConfiguracion;
        private System.Windows.Forms.Button btEstado;
        private System.Windows.Forms.Button btAnular;
        private System.Windows.Forms.PictureBox btCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btExcel;
        private System.Windows.Forms.Label label1;
    }
}

