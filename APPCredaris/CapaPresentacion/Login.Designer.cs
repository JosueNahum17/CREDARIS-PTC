namespace CapaPresentacion
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRecuperarContraseña = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlContrasena = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.ptbImgContrasena = new System.Windows.Forms.PictureBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlContrasena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgContrasena)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 431);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRecuperarContraseña);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Controls.Add(this.pnlContrasena);
            this.panel2.Controls.Add(this.pnlUsuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 431);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnRecuperarContraseña
            // 
            this.btnRecuperarContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecuperarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarContraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarContraseña.ForeColor = System.Drawing.Color.Black;
            this.btnRecuperarContraseña.Location = new System.Drawing.Point(203, 283);
            this.btnRecuperarContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            this.btnRecuperarContraseña.Size = new System.Drawing.Size(155, 52);
            this.btnRecuperarContraseña.TabIndex = 6;
            this.btnRecuperarContraseña.Text = "¿Olvidadestes tu contraseña?";
            this.btnRecuperarContraseña.UseVisualStyleBackColor = false;
            this.btnRecuperarContraseña.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Black;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(47, 283);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(134, 52);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlContrasena
            // 
            this.pnlContrasena.BackColor = System.Drawing.Color.White;
            this.pnlContrasena.Controls.Add(this.txtContrasena);
            this.pnlContrasena.Controls.Add(this.ptbImgContrasena);
            this.pnlContrasena.Location = new System.Drawing.Point(47, 183);
            this.pnlContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContrasena.Name = "pnlContrasena";
            this.pnlContrasena.Size = new System.Drawing.Size(338, 37);
            this.pnlContrasena.TabIndex = 4;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasena.Location = new System.Drawing.Point(41, 8);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(278, 21);
            this.txtContrasena.TabIndex = 7;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.Click += new System.EventHandler(this.txtContrasena_Click);
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // ptbImgContrasena
            // 
            this.ptbImgContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbImgContrasena.Image = global::CapaPresentacion.Properties.Resources.icons8_candado_50;
            this.ptbImgContrasena.Location = new System.Drawing.Point(2, 8);
            this.ptbImgContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbImgContrasena.Name = "ptbImgContrasena";
            this.ptbImgContrasena.Size = new System.Drawing.Size(23, 22);
            this.ptbImgContrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImgContrasena.TabIndex = 6;
            this.ptbImgContrasena.TabStop = false;
            this.ptbImgContrasena.Click += new System.EventHandler(this.ptbImgContrasena_Click);
            this.ptbImgContrasena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbImgContrasena_MouseDown);
            this.ptbImgContrasena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbImgContrasena_MouseUp);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.White;
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Controls.Add(this.pictureBox2);
            this.pnlUsuario.Location = new System.Drawing.Point(47, 138);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(338, 37);
            this.pnlUsuario.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(41, 6);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(278, 25);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.icons8_usuario_50;
            this.pictureBox2.Location = new System.Drawing.Point(4, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iniciar session en Credaris";
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.White;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.ForeColor = System.Drawing.Color.Blue;
            this.closebtn.Location = new System.Drawing.Point(370, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(41, 31);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 431);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlContrasena.ResumeLayout(false);
            this.pnlContrasena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgContrasena)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlContrasena;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ptbImgContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRecuperarContraseña;
    }
}

