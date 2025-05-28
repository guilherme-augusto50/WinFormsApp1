namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastro cadastroForm = new cadastro();
            cadastroForm.Show(); // Show the cadastro form
            this.Hide(); // Hide the current login form
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Exit the application when the form is closed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && txtsenha.Text.Equals("") && txtEmail.Text.Equals(""))
                {
                    Usuários usuario = new Usuários();
                    usuario.Nome = txtNome.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtsenha.Text;

                    usuario.logar();
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tela_principaç telaPrincipal = new Tela_principaç(usuario.ID);
                    telaPrincipal.Show(); // Show the main screen
                    this.Hide(); // Hide the login form after successful login
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    txtNome.Focus();
                    txtsenha.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
