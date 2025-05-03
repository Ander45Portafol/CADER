namespace CADER
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnDonaciones = new System.Windows.Forms.Button();
            this.BtnServicios = new System.Windows.Forms.Button();
            this.BtnAdministracion = new System.Windows.Forms.Button();
            this.BtnEventos = new System.Windows.Forms.Button();
            this.BtnFinanzas = new System.Windows.Forms.Button();
            this.BtnMobiliario = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.BtnDonaciones);
            this.panel1.Controls.Add(this.BtnServicios);
            this.panel1.Controls.Add(this.BtnAdministracion);
            this.panel1.Controls.Add(this.BtnEventos);
            this.panel1.Controls.Add(this.BtnFinanzas);
            this.panel1.Controls.Add(this.BtnMobiliario);
            this.panel1.Controls.Add(this.BtnInicio);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 879);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(231, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 46);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Image = global::CADER.Properties.Resources.x_regular_24;
            this.label1.Location = new System.Drawing.Point(1133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 46);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Image = global::CADER.Properties.Resources.log_out_solid_24;
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.Location = new System.Drawing.Point(3, 766);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(234, 53);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "Cerrar sesión";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnDonaciones
            // 
            this.BtnDonaciones.FlatAppearance.BorderSize = 0;
            this.BtnDonaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDonaciones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDonaciones.ForeColor = System.Drawing.Color.White;
            this.BtnDonaciones.Image = global::CADER.Properties.Resources.bxs_wallet_1;
            this.BtnDonaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDonaciones.Location = new System.Drawing.Point(3, 449);
            this.BtnDonaciones.Name = "BtnDonaciones";
            this.BtnDonaciones.Size = new System.Drawing.Size(234, 53);
            this.BtnDonaciones.TabIndex = 6;
            this.BtnDonaciones.Text = "Donaciones";
            this.BtnDonaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDonaciones.UseVisualStyleBackColor = true;
            // 
            // BtnServicios
            // 
            this.BtnServicios.FlatAppearance.BorderSize = 0;
            this.BtnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicios.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServicios.ForeColor = System.Drawing.Color.White;
            this.BtnServicios.Image = global::CADER.Properties.Resources.bx_clipboard_11;
            this.BtnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServicios.Location = new System.Drawing.Point(3, 390);
            this.BtnServicios.Name = "BtnServicios";
            this.BtnServicios.Size = new System.Drawing.Size(234, 53);
            this.BtnServicios.TabIndex = 5;
            this.BtnServicios.Text = "Servicios";
            this.BtnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServicios.UseVisualStyleBackColor = true;
            // 
            // BtnAdministracion
            // 
            this.BtnAdministracion.FlatAppearance.BorderSize = 0;
            this.BtnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministracion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministracion.ForeColor = System.Drawing.Color.White;
            this.BtnAdministracion.Image = global::CADER.Properties.Resources.bxs_book_alt_1;
            this.BtnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdministracion.Location = new System.Drawing.Point(3, 331);
            this.BtnAdministracion.Name = "BtnAdministracion";
            this.BtnAdministracion.Size = new System.Drawing.Size(234, 53);
            this.BtnAdministracion.TabIndex = 4;
            this.BtnAdministracion.Text = "Administración";
            this.BtnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdministracion.UseVisualStyleBackColor = true;
            // 
            // BtnEventos
            // 
            this.BtnEventos.FlatAppearance.BorderSize = 0;
            this.BtnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEventos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEventos.ForeColor = System.Drawing.Color.White;
            this.BtnEventos.Image = global::CADER.Properties.Resources.bxs_calendar_1;
            this.BtnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEventos.Location = new System.Drawing.Point(3, 272);
            this.BtnEventos.Name = "BtnEventos";
            this.BtnEventos.Size = new System.Drawing.Size(234, 53);
            this.BtnEventos.TabIndex = 3;
            this.BtnEventos.Text = "Eventos";
            this.BtnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEventos.UseVisualStyleBackColor = true;
            // 
            // BtnFinanzas
            // 
            this.BtnFinanzas.FlatAppearance.BorderSize = 0;
            this.BtnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinanzas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinanzas.ForeColor = System.Drawing.Color.White;
            this.BtnFinanzas.Image = global::CADER.Properties.Resources.bx_money_withdraw_1;
            this.BtnFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanzas.Location = new System.Drawing.Point(3, 213);
            this.BtnFinanzas.Name = "BtnFinanzas";
            this.BtnFinanzas.Size = new System.Drawing.Size(234, 53);
            this.BtnFinanzas.TabIndex = 2;
            this.BtnFinanzas.Text = "Finanzas";
            this.BtnFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFinanzas.UseVisualStyleBackColor = true;
            // 
            // BtnMobiliario
            // 
            this.BtnMobiliario.FlatAppearance.BorderSize = 0;
            this.BtnMobiliario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMobiliario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMobiliario.ForeColor = System.Drawing.Color.White;
            this.BtnMobiliario.Image = global::CADER.Properties.Resources.bxs_guitar_amp_1;
            this.BtnMobiliario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMobiliario.Location = new System.Drawing.Point(3, 154);
            this.BtnMobiliario.Name = "BtnMobiliario";
            this.BtnMobiliario.Size = new System.Drawing.Size(234, 53);
            this.BtnMobiliario.TabIndex = 1;
            this.BtnMobiliario.Text = "Mobiliario";
            this.BtnMobiliario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMobiliario.UseVisualStyleBackColor = true;
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.Image = global::CADER.Properties.Resources.bxs_home_alt_2_12;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(3, 95);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(234, 53);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            this.BtnInicio.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.BtnInicio.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.BtnInicio.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1421, 861);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnAdministracion;
        private System.Windows.Forms.Button BtnEventos;
        private System.Windows.Forms.Button BtnFinanzas;
        private System.Windows.Forms.Button BtnMobiliario;
        private System.Windows.Forms.Button BtnDonaciones;
        private System.Windows.Forms.Button BtnServicios;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

