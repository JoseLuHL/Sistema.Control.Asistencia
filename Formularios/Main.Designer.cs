namespace Sistema.Control.Asistencia
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lbletiquetaFecha = new System.Windows.Forms.Label();
            this.lbletiquetaHora = new System.Windows.Forms.Label();
            this.timerDiaActual = new System.Windows.Forms.Timer(this.components);
            this.IcoAyuda = new FontAwesome.Sharp.IconButton();
            this.IcoEmpleado = new FontAwesome.Sharp.IconButton();
            this.IcoIngresoSalida = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlIngresoSalida = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PnlUsuario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlIngresoSalida.SuspendLayout();
            this.PnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(636, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "00/00/000";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(737, 69);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 16);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "00:00:00";
            // 
            // lbletiquetaFecha
            // 
            this.lbletiquetaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbletiquetaFecha.AutoSize = true;
            this.lbletiquetaFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiquetaFecha.Location = new System.Drawing.Point(590, 69);
            this.lbletiquetaFecha.Name = "lbletiquetaFecha";
            this.lbletiquetaFecha.Size = new System.Drawing.Size(45, 16);
            this.lbletiquetaFecha.TabIndex = 5;
            this.lbletiquetaFecha.Text = "Fecha:";
            // 
            // lbletiquetaHora
            // 
            this.lbletiquetaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbletiquetaHora.AutoSize = true;
            this.lbletiquetaHora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiquetaHora.Location = new System.Drawing.Point(702, 69);
            this.lbletiquetaHora.Name = "lbletiquetaHora";
            this.lbletiquetaHora.Size = new System.Drawing.Size(37, 16);
            this.lbletiquetaHora.TabIndex = 6;
            this.lbletiquetaHora.Text = "Hora:";
            // 
            // timerDiaActual
            // 
            this.timerDiaActual.Tick += new System.EventHandler(this.timerDiaActual_Tick);
            // 
            // IcoAyuda
            // 
            this.IcoAyuda.BackColor = System.Drawing.Color.Transparent;
            this.IcoAyuda.FlatAppearance.BorderSize = 0;
            this.IcoAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcoAyuda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IcoAyuda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcoAyuda.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.IcoAyuda.IconColor = System.Drawing.Color.Black;
            this.IcoAyuda.IconSize = 90;
            this.IcoAyuda.Location = new System.Drawing.Point(585, 16);
            this.IcoAyuda.Name = "IcoAyuda";
            this.IcoAyuda.Rotation = 0D;
            this.IcoAyuda.Size = new System.Drawing.Size(167, 129);
            this.IcoAyuda.TabIndex = 18;
            this.IcoAyuda.Text = "Ver ingreso y salida";
            this.IcoAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IcoAyuda.UseVisualStyleBackColor = false;
            this.IcoAyuda.Click += new System.EventHandler(this.IcoAyuda_Click);
            // 
            // IcoEmpleado
            // 
            this.IcoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.IcoEmpleado.FlatAppearance.BorderSize = 0;
            this.IcoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcoEmpleado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IcoEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcoEmpleado.IconChar = FontAwesome.Sharp.IconChar.Poo;
            this.IcoEmpleado.IconColor = System.Drawing.Color.Black;
            this.IcoEmpleado.IconSize = 90;
            this.IcoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IcoEmpleado.Location = new System.Drawing.Point(253, 16);
            this.IcoEmpleado.Name = "IcoEmpleado";
            this.IcoEmpleado.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.IcoEmpleado.Rotation = 0D;
            this.IcoEmpleado.Size = new System.Drawing.Size(167, 129);
            this.IcoEmpleado.TabIndex = 16;
            this.IcoEmpleado.Text = "Empleado";
            this.IcoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IcoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IcoEmpleado.UseVisualStyleBackColor = false;
            this.IcoEmpleado.Click += new System.EventHandler(this.IcoEmpleado_Click);
            // 
            // IcoIngresoSalida
            // 
            this.IcoIngresoSalida.BackColor = System.Drawing.Color.Transparent;
            this.IcoIngresoSalida.FlatAppearance.BorderSize = 0;
            this.IcoIngresoSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcoIngresoSalida.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IcoIngresoSalida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcoIngresoSalida.IconChar = FontAwesome.Sharp.IconChar.Dungeon;
            this.IcoIngresoSalida.IconColor = System.Drawing.Color.Black;
            this.IcoIngresoSalida.IconSize = 90;
            this.IcoIngresoSalida.Location = new System.Drawing.Point(39, 16);
            this.IcoIngresoSalida.Name = "IcoIngresoSalida";
            this.IcoIngresoSalida.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.IcoIngresoSalida.Rotation = 0D;
            this.IcoIngresoSalida.Size = new System.Drawing.Size(184, 129);
            this.IcoIngresoSalida.TabIndex = 15;
            this.IcoIngresoSalida.Text = "Ingreso y Salida";
            this.IcoIngresoSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IcoIngresoSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IcoIngresoSalida.UseVisualStyleBackColor = false;
            this.IcoIngresoSalida.Click += new System.EventHandler(this.IcoIngresoSalida_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 124);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // PnlIngresoSalida
            // 
            this.PnlIngresoSalida.BackColor = System.Drawing.Color.White;
            this.PnlIngresoSalida.Controls.Add(this.iconButton1);
            this.PnlIngresoSalida.Controls.Add(this.IcoAyuda);
            this.PnlIngresoSalida.Controls.Add(this.IcoEmpleado);
            this.PnlIngresoSalida.Controls.Add(this.IcoIngresoSalida);
            this.PnlIngresoSalida.Location = new System.Drawing.Point(12, 116);
            this.PnlIngresoSalida.Name = "PnlIngresoSalida";
            this.PnlIngresoSalida.Size = new System.Drawing.Size(775, 257);
            this.PnlIngresoSalida.TabIndex = 16;
            this.PnlIngresoSalida.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Female;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 90;
            this.iconButton1.Location = new System.Drawing.Point(412, 16);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(167, 138);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.Text = "Reporte de ingreso y salida";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // PnlUsuario
            // 
            this.PnlUsuario.Controls.Add(this.label2);
            this.PnlUsuario.Controls.Add(this.label1);
            this.PnlUsuario.Controls.Add(this.iconPictureBox1);
            this.PnlUsuario.Controls.Add(this.TxtUsuario);
            this.PnlUsuario.Controls.Add(this.TxtContraseña);
            this.PnlUsuario.Controls.Add(this.BtnIniciarSesion);
            this.PnlUsuario.Location = new System.Drawing.Point(9, 76);
            this.PnlUsuario.Name = "PnlUsuario";
            this.PnlUsuario.Size = new System.Drawing.Size(272, 410);
            this.PnlUsuario.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 67;
            this.iconPictureBox1.Location = new System.Drawing.Point(101, 59);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(93, 67);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(50, 166);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(175, 27);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtContraseña.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(50, 228);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(175, 27);
            this.TxtContraseña.TabIndex = 2;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.DarkGray;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(77, 288);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(117, 39);
            this.BtnIniciarSesion.TabIndex = 3;
            this.BtnIniciarSesion.Text = "Entrar";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 517);
            this.Controls.Add(this.PnlUsuario);
            this.Controls.Add(this.PnlIngresoSalida);
            this.Controls.Add(this.lbletiquetaHora);
            this.Controls.Add(this.lbletiquetaFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Asistencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlIngresoSalida.ResumeLayout(false);
            this.PnlUsuario.ResumeLayout(false);
            this.PnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lbletiquetaFecha;
        private System.Windows.Forms.Label lbletiquetaHora;
        private System.Windows.Forms.Timer timerDiaActual;
        private FontAwesome.Sharp.IconButton IcoAyuda;
        private FontAwesome.Sharp.IconButton IcoEmpleado;
        private FontAwesome.Sharp.IconButton IcoIngresoSalida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlIngresoSalida;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PnlUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

