namespace Practico2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNomyApe = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMaster = new System.Windows.Forms.CheckBox();
            this.checkBoxVisa = new System.Windows.Forms.CheckBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.checkBoxNaranja = new System.Windows.Forms.CheckBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnVaron = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomyApe
            // 
            this.lblNomyApe.AutoSize = true;
            this.lblNomyApe.Location = new System.Drawing.Point(3, 16);
            this.lblNomyApe.Name = "lblNomyApe";
            this.lblNomyApe.Size = new System.Drawing.Size(92, 13);
            this.lblNomyApe.TabIndex = 4;
            this.lblNomyApe.Text = "Nombre y Apellido";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.ForeColor = System.Drawing.Color.Red;
            this.lblModificar.Location = new System.Drawing.Point(135, 16);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(49, 13);
            this.lblModificar.TabIndex = 11;
            this.lblModificar.Text = "modificar";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(23, 56);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 13);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "* DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(84, 49);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "* Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 84);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 13);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "* Apellido";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.checkBoxMaster);
            this.panel1.Controls.Add(this.checkBoxVisa);
            this.panel1.Controls.Add(this.lblTarjeta);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.checkBoxNaranja);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblNomyApe);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Location = new System.Drawing.Point(24, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 261);
            this.panel1.TabIndex = 20;
            // 
            // checkBoxMaster
            // 
            this.checkBoxMaster.AutoSize = true;
            this.checkBoxMaster.Location = new System.Drawing.Point(127, 209);
            this.checkBoxMaster.Name = "checkBoxMaster";
            this.checkBoxMaster.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMaster.TabIndex = 28;
            this.checkBoxMaster.Text = "Mastercard";
            this.checkBoxMaster.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisa
            // 
            this.checkBoxVisa.AutoSize = true;
            this.checkBoxVisa.Location = new System.Drawing.Point(127, 186);
            this.checkBoxVisa.Name = "checkBoxVisa";
            this.checkBoxVisa.Size = new System.Drawing.Size(46, 17);
            this.checkBoxVisa.TabIndex = 27;
            this.checkBoxVisa.Text = "Visa";
            this.checkBoxVisa.UseVisualStyleBackColor = true;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(23, 162);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(98, 13);
            this.lblTarjeta.TabIndex = 26;
            this.lblTarjeta.Text = "Tarjeta de creditos:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(84, 129);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 25;
            // 
            // checkBoxNaranja
            // 
            this.checkBoxNaranja.AutoSize = true;
            this.checkBoxNaranja.Location = new System.Drawing.Point(127, 163);
            this.checkBoxNaranja.Name = "checkBoxNaranja";
            this.checkBoxNaranja.Size = new System.Drawing.Size(63, 17);
            this.checkBoxNaranja.TabIndex = 24;
            this.checkBoxNaranja.Text = "Naranja";
            this.checkBoxNaranja.UseVisualStyleBackColor = true;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 133);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Telefono";
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Location = new System.Drawing.Point(393, 190);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtnMujer.TabIndex = 22;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.CheckedChanged += new System.EventHandler(this.rbtnMujer_CheckedChanged_1);
            // 
            // rbtnVaron
            // 
            this.rbtnVaron.AutoSize = true;
            this.rbtnVaron.Checked = true;
            this.rbtnVaron.Location = new System.Drawing.Point(314, 190);
            this.rbtnVaron.Name = "rbtnVaron";
            this.rbtnVaron.Size = new System.Drawing.Size(53, 17);
            this.rbtnVaron.TabIndex = 23;
            this.rbtnVaron.TabStop = true;
            this.rbtnVaron.Text = "Varon";
            this.rbtnVaron.UseVisualStyleBackColor = true;
            this.rbtnVaron.CheckedChanged += new System.EventHandler(this.rbtnVaron_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(339, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 70);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practico2.Properties.Resources.jefe;
            this.pictureBox1.Location = new System.Drawing.Point(314, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(180, 316);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 70);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 70);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rbtnVaron);
            this.Controls.Add(this.rbtnMujer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Pequeño Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomyApe;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.RadioButton rbtnVaron;
        private System.Windows.Forms.CheckBox checkBoxMaster;
        private System.Windows.Forms.CheckBox checkBoxVisa;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox checkBoxNaranja;
        private System.Windows.Forms.Button btnSalir;
    }
}

