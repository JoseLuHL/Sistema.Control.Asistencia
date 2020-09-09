namespace Sistema.Control.Asistencia.Formularios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.ChkEstado = new MaterialSkin.Controls.MaterialCheckBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.ChkFecha = new MaterialSkin.Controls.MaterialCheckBox();
            this.CboEmpleado = new System.Windows.Forms.ComboBox();
            this.chkEmpleado = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Control.Asistencia.InfIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(820, 287);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CboEstado);
            this.panel1.Controls.Add(this.ChkEstado);
            this.panel1.Controls.Add(this.DtFecha);
            this.panel1.Controls.Add(this.ChkFecha);
            this.panel1.Controls.Add(this.CboEmpleado);
            this.panel1.Controls.Add(this.chkEmpleado);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 86);
            this.panel1.TabIndex = 1;
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.Enabled = false;
            this.CboEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(548, 41);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(164, 25);
            this.CboEstado.TabIndex = 5;
            this.CboEstado.SelectionChangeCommitted += new System.EventHandler(this.CboEstado_SelectionChangeCommitted);
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.Depth = 0;
            this.ChkEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkEstado.Location = new System.Drawing.Point(545, 8);
            this.ChkEstado.Margin = new System.Windows.Forms.Padding(0);
            this.ChkEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Ripple = true;
            this.ChkEstado.Size = new System.Drawing.Size(72, 30);
            this.ChkEstado.TabIndex = 4;
            this.ChkEstado.Text = "Estado";
            this.ChkEstado.UseVisualStyleBackColor = true;
            this.ChkEstado.CheckedChanged += new System.EventHandler(this.materialCheckBox3_CheckedChanged);
            // 
            // DtFecha
            // 
            this.DtFecha.Enabled = false;
            this.DtFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFecha.Location = new System.Drawing.Point(264, 43);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(259, 23);
            this.DtFecha.TabIndex = 3;
            this.DtFecha.ValueChanged += new System.EventHandler(this.DtFecha_ValueChanged);
            // 
            // ChkFecha
            // 
            this.ChkFecha.AutoSize = true;
            this.ChkFecha.Depth = 0;
            this.ChkFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkFecha.Location = new System.Drawing.Point(264, 9);
            this.ChkFecha.Margin = new System.Windows.Forms.Padding(0);
            this.ChkFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkFecha.Name = "ChkFecha";
            this.ChkFecha.Ripple = true;
            this.ChkFecha.Size = new System.Drawing.Size(67, 30);
            this.ChkFecha.TabIndex = 2;
            this.ChkFecha.Text = "Fecha";
            this.ChkFecha.UseVisualStyleBackColor = true;
            this.ChkFecha.CheckedChanged += new System.EventHandler(this.materialCheckBox2_CheckedChanged);
            // 
            // CboEmpleado
            // 
            this.CboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEmpleado.Enabled = false;
            this.CboEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEmpleado.FormattingEnabled = true;
            this.CboEmpleado.Location = new System.Drawing.Point(12, 42);
            this.CboEmpleado.Name = "CboEmpleado";
            this.CboEmpleado.Size = new System.Drawing.Size(240, 25);
            this.CboEmpleado.TabIndex = 1;
            this.CboEmpleado.SelectionChangeCommitted += new System.EventHandler(this.CboEmpleado_SelectionChangeCommitted);
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.Depth = 0;
            this.chkEmpleado.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEmpleado.Location = new System.Drawing.Point(9, 9);
            this.chkEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.chkEmpleado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.Ripple = true;
            this.chkEmpleado.Size = new System.Drawing.Size(91, 30);
            this.chkEmpleado.TabIndex = 0;
            this.chkEmpleado.Text = "Empleado";
            this.chkEmpleado.UseVisualStyleBackColor = true;
            this.chkEmpleado.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "-------------------------------------";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CboEstado;
        private MaterialSkin.Controls.MaterialCheckBox ChkEstado;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private MaterialSkin.Controls.MaterialCheckBox ChkFecha;
        private System.Windows.Forms.ComboBox CboEmpleado;
        private MaterialSkin.Controls.MaterialCheckBox chkEmpleado;
    }
}