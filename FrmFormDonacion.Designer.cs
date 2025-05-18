namespace CADER
{
    partial class FrmFormDonacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCerrarForm = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.dtFechDonacion = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fecha de Donación";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(80, 195);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(279, 24);
            this.cmbUsuario.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Cantidad de Donación";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(80, 117);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(280, 22);
            this.txtCantidad.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Descripción de Donación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "label5";
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrarForm.FlatAppearance.BorderSize = 0;
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Image = global::CADER.Properties.Resources.x_regular_241;
            this.BtnCerrarForm.Location = new System.Drawing.Point(746, 2);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(53, 37);
            this.BtnCerrarForm.TabIndex = 50;
            this.BtnCerrarForm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCerrarForm.UseVisualStyleBackColor = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnEliminar.Location = new System.Drawing.Point(560, 342);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(207, 48);
            this.BtnEliminar.TabIndex = 61;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnConfirmar.Location = new System.Drawing.Point(560, 288);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(207, 48);
            this.BtnConfirmar.TabIndex = 60;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // dtFechDonacion
            // 
            this.dtFechDonacion.Location = new System.Drawing.Point(80, 288);
            this.dtFechDonacion.Name = "dtFechDonacion";
            this.dtFechDonacion.Size = new System.Drawing.Size(279, 22);
            this.dtFechDonacion.TabIndex = 62;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(412, 117);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(286, 84);
            this.txtDescripcion.TabIndex = 63;
            // 
            // FrmFormDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtFechDonacion);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCerrarForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFormDonacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFormDonacion";
            this.Load += new System.EventHandler(this.FrmFormDonacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.DateTimePicker dtFechDonacion;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}