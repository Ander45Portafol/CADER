namespace CADER
{
    partial class FrmFormMobiliario
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
            this.BtnCerrarForm = new System.Windows.Forms.Button();
            this.cmbObjeto = new System.Windows.Forms.ComboBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrarForm.FlatAppearance.BorderSize = 0;
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Image = global::CADER.Properties.Resources.x_regular_241;
            this.BtnCerrarForm.Location = new System.Drawing.Point(743, 2);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(53, 37);
            this.BtnCerrarForm.TabIndex = 0;
            this.BtnCerrarForm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCerrarForm.UseVisualStyleBackColor = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // cmbObjeto
            // 
            this.cmbObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjeto.FormattingEnabled = true;
            this.cmbObjeto.Location = new System.Drawing.Point(71, 87);
            this.cmbObjeto.Name = "cmbObjeto";
            this.cmbObjeto.Size = new System.Drawing.Size(280, 24);
            this.cmbObjeto.TabIndex = 1;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(424, 87);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(280, 24);
            this.cmbGrupo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Objeto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grupo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(424, 174);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de Uso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha para Regresar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button1.Location = new System.Drawing.Point(497, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmFormMobiliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.cmbObjeto);
            this.Controls.Add(this.BtnCerrarForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFormMobiliario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.ComboBox cmbObjeto;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}