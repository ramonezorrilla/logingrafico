namespace logingrafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtpassword = new TextBox();
            lblUsuario = new Label();
            lblPassword = new Label();
            pictureBox1 = new PictureBox();
            btncancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(282, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(308, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROL DE ACCESO";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(326, 269);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(373, 134);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(128, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(373, 190);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(128, 23);
            txtpassword.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(299, 142);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "USUARIO";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(299, 198);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "PASSWORD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(426, 269);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 7;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(596, 304);
            Controls.Add(btncancelar);
            Controls.Add(pictureBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(txtpassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtpassword;
        private Label lblUsuario;
        private Label lblPassword;
        private PictureBox pictureBox1;
        private Button btncancelar;
    }
}
