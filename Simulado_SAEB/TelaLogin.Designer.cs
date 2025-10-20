namespace Simulado_SAEB
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            Login_Usuario = new TextBox();
            Login_Senha = new TextBox();
            Login = new Button();
            SuspendLayout();
            // 
            // Login_Usuario
            // 
            Login_Usuario.Font = new Font("Segoe UI", 20F);
            Login_Usuario.Location = new Point(203, 133);
            Login_Usuario.Name = "Login_Usuario";
            Login_Usuario.Size = new Size(376, 43);
            Login_Usuario.TabIndex = 1;
            Login_Usuario.Text = "Usuario:";
            Login_Usuario.TextChanged += Login_Usuario_TextChanged_1;
            // 
            // Login_Senha
            // 
            Login_Senha.Font = new Font("Segoe UI", 20F);
            Login_Senha.Location = new Point(203, 208);
            Login_Senha.Name = "Login_Senha";
            Login_Senha.Size = new Size(376, 43);
            Login_Senha.TabIndex = 2;
            Login_Senha.Text = "Senha:";
            Login_Senha.TextChanged += Login_Senha_TextChanged_1;
            // 
            // Login
            // 
            Login.BackColor = Color.White;
            Login.Font = new Font("Segoe UI", 20F);
            Login.Location = new Point(288, 272);
            Login.Name = "Login";
            Login.Size = new Size(199, 62);
            Login.TabIndex = 3;
            Login.Text = "LOGAR";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(129, 191, 248);
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(Login_Senha);
            Controls.Add(Login_Usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaLogin";
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Login_Usuario;
        private TextBox Login_Senha;
        private Button Login;
    }
}