namespace Simulado_SAEB
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
            pictureBox1 = new PictureBox();
            Cadastro = new Button();
            Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(199, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Cadastro
            // 
            Cadastro.BackColor = Color.White;
            Cadastro.Font = new Font("Segoe UI", 16F);
            Cadastro.ForeColor = SystemColors.ControlText;
            Cadastro.Location = new Point(289, 236);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(227, 58);
            Cadastro.TabIndex = 1;
            Cadastro.Text = "Fazer Cadastro";
            Cadastro.UseVisualStyleBackColor = false;
            Cadastro.Click += Cadastro_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.White;
            Login.Font = new Font("Segoe UI", 16F);
            Login.Location = new Point(289, 300);
            Login.Name = "Login";
            Login.Size = new Size(227, 58);
            Login.TabIndex = 2;
            Login.Text = "Fazer Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(129, 191, 248);
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(Cadastro);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Cadastro;
        private Button Login;
    }
}
