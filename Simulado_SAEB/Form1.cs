namespace Simulado_SAEB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro telacadastro = new TelaCadastro(this);
            this.Hide();
            telacadastro.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            this.Hide();
            telaLogin.Show();
        }
    }
}
