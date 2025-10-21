namespace Simulado_SAEB
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            Cadastrar_Cliente = new Button();
            Cadastrar_Passagem = new Button();
            Agendar_Passagem = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Cadastrar_Cliente
            // 
            Cadastrar_Cliente.BackColor = Color.White;
            Cadastrar_Cliente.Font = new Font("Segoe UI", 15F);
            Cadastrar_Cliente.Location = new Point(316, 59);
            Cadastrar_Cliente.Name = "Cadastrar_Cliente";
            Cadastrar_Cliente.Size = new Size(174, 82);
            Cadastrar_Cliente.TabIndex = 0;
            Cadastrar_Cliente.Text = "Cadastrar Cliente";
            Cadastrar_Cliente.UseVisualStyleBackColor = false;
            // 
            // Cadastrar_Passagem
            // 
            Cadastrar_Passagem.BackColor = Color.White;
            Cadastrar_Passagem.Font = new Font("Segoe UI", 15F);
            Cadastrar_Passagem.Location = new Point(316, 164);
            Cadastrar_Passagem.Name = "Cadastrar_Passagem";
            Cadastrar_Passagem.Size = new Size(174, 82);
            Cadastrar_Passagem.TabIndex = 1;
            Cadastrar_Passagem.Text = "Cadastrar Passagem";
            Cadastrar_Passagem.UseVisualStyleBackColor = false;
            // 
            // Agendar_Passagem
            // 
            Agendar_Passagem.BackColor = Color.White;
            Agendar_Passagem.Font = new Font("Segoe UI", 15F);
            Agendar_Passagem.Location = new Point(316, 272);
            Agendar_Passagem.Name = "Agendar_Passagem";
            Agendar_Passagem.Size = new Size(174, 82);
            Agendar_Passagem.TabIndex = 2;
            Agendar_Passagem.Text = "Agendar Passagem";
            Agendar_Passagem.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-253, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1075, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(129, 191, 248);
            ClientSize = new Size(800, 450);
            Controls.Add(Agendar_Passagem);
            Controls.Add(Cadastrar_Passagem);
            Controls.Add(Cadastrar_Cliente);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Cadastrar_Cliente;
        private Button Cadastrar_Passagem;
        private Button Agendar_Passagem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}