namespace CADER
{
    partial class FrmFinanzas
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
            this.PanelFinanzas = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOfrendas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCuotas = new System.Windows.Forms.Button();
            this.PanelFinanzas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFinanzas
            // 
            this.PanelFinanzas.Controls.Add(this.label4);
            this.PanelFinanzas.Controls.Add(this.BtnReporte);
            this.PanelFinanzas.Controls.Add(this.label2);
            this.PanelFinanzas.Controls.Add(this.BtnOfrendas);
            this.PanelFinanzas.Controls.Add(this.label3);
            this.PanelFinanzas.Controls.Add(this.BtnCuotas);
            this.PanelFinanzas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFinanzas.Location = new System.Drawing.Point(0, 0);
            this.PanelFinanzas.Name = "PanelFinanzas";
            this.PanelFinanzas.Size = new System.Drawing.Size(902, 656);
            this.PanelFinanzas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "FINANZAS";
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.Image = global::CADER.Properties.Resources.bxs_report_1;
            this.BtnReporte.Location = new System.Drawing.Point(727, 14);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(153, 47);
            this.BtnReporte.TabIndex = 11;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReporte.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ofrendas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnOfrendas
            // 
            this.BtnOfrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnOfrendas.FlatAppearance.BorderSize = 0;
            this.BtnOfrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOfrendas.Image = global::CADER.Properties.Resources.bxs_envelope_1;
            this.BtnOfrendas.Location = new System.Drawing.Point(78, 174);
            this.BtnOfrendas.Name = "BtnOfrendas";
            this.BtnOfrendas.Size = new System.Drawing.Size(349, 345);
            this.BtnOfrendas.TabIndex = 9;
            this.BtnOfrendas.UseVisualStyleBackColor = false;
            this.BtnOfrendas.Click += new System.EventHandler(this.BtnOfrendas_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuotas";
            // 
            // BtnCuotas
            // 
            this.BtnCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnCuotas.FlatAppearance.BorderSize = 0;
            this.BtnCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuotas.Image = global::CADER.Properties.Resources.bx_money_1;
            this.BtnCuotas.Location = new System.Drawing.Point(489, 174);
            this.BtnCuotas.Name = "BtnCuotas";
            this.BtnCuotas.Size = new System.Drawing.Size(349, 345);
            this.BtnCuotas.TabIndex = 7;
            this.BtnCuotas.UseVisualStyleBackColor = false;
            this.BtnCuotas.Click += new System.EventHandler(this.BtnCuotas_Click);
            // 
            // FrmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 656);
            this.Controls.Add(this.PanelFinanzas);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFinanzas";
            this.Text = "Finanzas";
            this.PanelFinanzas.ResumeLayout(false);
            this.PanelFinanzas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelFinanzas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOfrendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCuotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReporte;
    }
}