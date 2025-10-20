namespace Simulado_SAEB
{
    partial class TelaCadastro
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
            Text_Usuario = new TextBox();
            Text_Senha = new TextBox();
            Cadastrar = new Button();
            SuspendLayout();
            // 
            // Text_Usuario
            // 
            Text_Usuario.Font = new Font("Segoe UI", 20F);
            Text_Usuario.Location = new Point(208, 129);
            Text_Usuario.Name = "Text_Usuario";
            Text_Usuario.Size = new Size(376, 43);
            Text_Usuario.TabIndex = 0;
            Text_Usuario.TextChanged += Text_Usuario_TextChanged;
            // 
            // Text_Senha
            // 
            Text_Senha.Font = new Font("Segoe UI", 20F);
            Text_Senha.Location = new Point(208, 204);
            Text_Senha.Name = "Text_Senha";
            Text_Senha.Size = new Size(376, 43);
            Text_Senha.TabIndex = 1;
            Text_Senha.TextChanged += Text_Senha_TextChanged;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.White;
            Cadastrar.Font = new Font("Segoe UI", 20F);
            Cadastrar.Location = new Point(294, 286);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(199, 62);
            Cadastrar.TabIndex = 2;
            Cadastrar.Text = "CADASTRAR";
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(129, 191, 248);
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastrar);
            Controls.Add(Text_Senha);
            Controls.Add(Text_Usuario);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Text_Usuario;
        private TextBox Text_Senha;
        private Button Cadastrar;
    }
}