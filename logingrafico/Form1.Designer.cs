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
            lblTitulo = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtpassword = new TextBox();
            lblUsuario = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(318, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROL DE ACCESO";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(357, 296);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(401, 134);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(401, 190);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(100, 23);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(txtpassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
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
    }
}
