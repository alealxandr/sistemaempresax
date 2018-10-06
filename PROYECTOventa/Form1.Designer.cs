namespace PROYECTOventa
{
    partial class principalform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principalform));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.panelbarratitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnproveedores = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btnrecibo = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelbarratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelContenedor.Controls.Add(this.panelformularios);
            this.panelContenedor.Controls.Add(this.panelbarratitulo);
            this.panelContenedor.Controls.Add(this.panelmenu);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1219, 650);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelformularios
            // 
            this.panelformularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.Location = new System.Drawing.Point(200, 55);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(1019, 595);
            this.panelformularios.TabIndex = 2;
            this.panelformularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelformularios_Paint);
            // 
            // panelbarratitulo
            // 
            this.panelbarratitulo.BackColor = System.Drawing.Color.White;
            this.panelbarratitulo.Controls.Add(this.pictureBox1);
            this.panelbarratitulo.Controls.Add(this.btnrestaurar);
            this.panelbarratitulo.Controls.Add(this.btnminimizar);
            this.panelbarratitulo.Controls.Add(this.btnmaximizar);
            this.panelbarratitulo.Controls.Add(this.btncerrar);
            this.panelbarratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbarratitulo.Location = new System.Drawing.Point(200, 0);
            this.panelbarratitulo.Name = "panelbarratitulo";
            this.panelbarratitulo.Size = new System.Drawing.Size(1019, 55);
            this.panelbarratitulo.TabIndex = 1;
            this.panelbarratitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panelbarratitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelbarratitulo_MouseMove_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(933, 0);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(49, 55);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 3;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Visible = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(892, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(42, 52);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(940, 0);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(42, 52);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 1;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(979, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(40, 52);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelmenu.Controls.Add(this.pictureBox2);
            this.panelmenu.Controls.Add(this.button1);
            this.panelmenu.Controls.Add(this.btninventario);
            this.panelmenu.Controls.Add(this.btnproveedores);
            this.panelmenu.Controls.Add(this.btnclientes);
            this.panelmenu.Controls.Add(this.btnproducto);
            this.panelmenu.Controls.Add(this.btnventa);
            this.panelmenu.Controls.Add(this.btnrecibo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(200, 650);
            this.panelmenu.TabIndex = 0;
            // 
            // btnproveedores
            // 
            this.btnproveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnproveedores.FlatAppearance.BorderSize = 0;
            this.btnproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedores.ForeColor = System.Drawing.Color.Black;
            this.btnproveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnproveedores.Image")));
            this.btnproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproveedores.Location = new System.Drawing.Point(0, 351);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(200, 46);
            this.btnproveedores.TabIndex = 4;
            this.btnproveedores.Text = "PROVEEDORES";
            this.btnproveedores.UseVisualStyleBackColor = false;
            this.btnproveedores.Click += new System.EventHandler(this.btnproveedores_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.ForeColor = System.Drawing.Color.Black;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 299);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(200, 46);
            this.btnclientes.TabIndex = 3;
            this.btnclientes.Text = "CLIENTES";
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnproducto
            // 
            this.btnproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnproducto.FlatAppearance.BorderSize = 0;
            this.btnproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducto.ForeColor = System.Drawing.Color.Black;
            this.btnproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnproducto.Image")));
            this.btnproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducto.Location = new System.Drawing.Point(-3, 247);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(200, 46);
            this.btnproducto.TabIndex = 2;
            this.btnproducto.Text = "PRODUCTOS";
            this.btnproducto.UseVisualStyleBackColor = false;
            this.btnproducto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnventa
            // 
            this.btnventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnventa.FlatAppearance.BorderSize = 0;
            this.btnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventa.ForeColor = System.Drawing.Color.Black;
            this.btnventa.Image = ((System.Drawing.Image)(resources.GetObject("btnventa.Image")));
            this.btnventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventa.Location = new System.Drawing.Point(0, 180);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(200, 46);
            this.btnventa.TabIndex = 1;
            this.btnventa.Text = "VENTAS";
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrecibo
            // 
            this.btnrecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnrecibo.FlatAppearance.BorderSize = 0;
            this.btnrecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecibo.ForeColor = System.Drawing.Color.Black;
            this.btnrecibo.Image = ((System.Drawing.Image)(resources.GetObject("btnrecibo.Image")));
            this.btnrecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecibo.Location = new System.Drawing.Point(0, 128);
            this.btnrecibo.Name = "btnrecibo";
            this.btnrecibo.Size = new System.Drawing.Size(200, 46);
            this.btnrecibo.TabIndex = 0;
            this.btnrecibo.Text = "RECIBO";
            this.btnrecibo.UseVisualStyleBackColor = false;
            this.btnrecibo.Click += new System.EventHandler(this.btnrecibo_Click);
            // 
            // btninventario
            // 
            this.btninventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btninventario.FlatAppearance.BorderSize = 0;
            this.btninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventario.ForeColor = System.Drawing.Color.Black;
            this.btninventario.Image = ((System.Drawing.Image)(resources.GetObject("btninventario.Image")));
            this.btninventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninventario.Location = new System.Drawing.Point(0, 415);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(200, 46);
            this.btninventario.TabIndex = 5;
            this.btninventario.Text = "INVENTARIO";
            this.btninventario.UseVisualStyleBackColor = false;
            this.btninventario.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "REPORTES";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // principalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "principalform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.panelbarratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Panel panelbarratitulo;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnrecibo;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnproveedores;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

