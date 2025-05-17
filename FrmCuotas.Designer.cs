namespace CADER
{
    partial class FrmCuotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelCuota = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCuota = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblDay = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.PanelCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuota)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCuota
            // 
            this.PanelCuota.Controls.Add(this.label1);
            this.PanelCuota.Controls.Add(this.DgvCuota);
            this.PanelCuota.Controls.Add(this.panel2);
            this.PanelCuota.Controls.Add(this.BtnAgregar);
            this.PanelCuota.Controls.Add(this.BtnRegresar);
            this.PanelCuota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCuota.Location = new System.Drawing.Point(0, 0);
            this.PanelCuota.Name = "PanelCuota";
            this.PanelCuota.Size = new System.Drawing.Size(905, 656);
            this.PanelCuota.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "CUOTAS";
            // 
            // DgvCuota
            // 
            this.DgvCuota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCuota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCuota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCuota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCuota.Location = new System.Drawing.Point(37, 232);
            this.DgvCuota.Name = "DgvCuota";
            this.DgvCuota.ReadOnly = true;
            this.DgvCuota.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvCuota.RowTemplate.Height = 24;
            this.DgvCuota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvCuota.Size = new System.Drawing.Size(845, 395);
            this.DgvCuota.StandardTab = true;
            this.DgvCuota.TabIndex = 28;
            this.DgvCuota.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCuota_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.LblDay);
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Location = new System.Drawing.Point(37, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 78);
            this.panel2.TabIndex = 27;
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDay.Location = new System.Drawing.Point(709, 27);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(123, 19);
            this.LblDay.TabIndex = 3;
            this.LblDay.Text = "dd/mm/YYYY";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(20, 23);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(579, 28);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.Text = "Buscar";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::CADER.Properties.Resources.plus_circle_regular_24;
            this.BtnAgregar.Location = new System.Drawing.Point(758, 34);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(124, 42);
            this.BtnAgregar.TabIndex = 26;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Location = new System.Drawing.Point(23, 33);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(116, 27);
            this.BtnRegresar.TabIndex = 29;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click_1);
            // 
            // FrmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 656);
            this.Controls.Add(this.PanelCuota);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCuotas";
            this.Text = "FrmCoutas";
            this.Load += new System.EventHandler(this.FrmCuotas_Load);
            this.PanelCuota.ResumeLayout(false);
            this.PanelCuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuota)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCuota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnRegresar;
    }
}