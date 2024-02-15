namespace presentacion
{
    partial class frmAgregar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(79, 45);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(119, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código de articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(139, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(116, 244);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(150, 124);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(132, 168);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(69, 16);
            this.lblcategoria.TabIndex = 4;
            this.lblcategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(148, 210);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(215, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 22);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(214, 204);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(146, 22);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(214, 241);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(146, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(214, 165);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(147, 24);
            this.cbxCategoria.TabIndex = 12;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(215, 124);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(147, 24);
            this.cbxMarca.TabIndex = 13;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(82, 320);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(279, 192);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 14;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(82, 537);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 32);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 537);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 32);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(83, 278);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(115, 16);
            this.lblUrlImagen.TabIndex = 19;
            this.lblUrlImagen.Text = "URL de la imagen";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(214, 278);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(148, 22);
            this.txtUrlImagen.TabIndex = 20;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.Location = new System.Drawing.Point(369, 278);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(33, 23);
            this.btnAgregarArchivo.TabIndex = 21;
            this.btnAgregarArchivo.Text = "+";
            this.btnAgregarArchivo.UseVisualStyleBackColor = true;
            this.btnAgregarArchivo.Click += new System.EventHandler(this.btnAgregarArchivo_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 602);
            this.Controls.Add(this.btnAgregarArchivo);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAgregar";
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAgregarArchivo;
    }
}