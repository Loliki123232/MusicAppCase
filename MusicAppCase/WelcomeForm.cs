namespace MusicAppCase
{
    public partial class WelcomeForm : Form
    {
        Authenticator authenticator = new Authenticator();
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        private string selectedLogin;
        private string selectedPassword;
        public WelcomeForm()
        {
            InitializeComponent();
            dbConnection.OpenConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            selectedLogin = txtBoxLogin.Text;
            selectedPassword = txtBoxPassword.Text;
            if (string.IsNullOrEmpty(selectedLogin) || string.IsNullOrEmpty(selectedPassword))
            {
                MessageBox.Show("����������, ������� login � password.");
                return;
            }
            if (selectedLogin.Equals(selectedPassword, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("������ �� ������ ��������� � login.");
                return;
            }
            if (authenticator.AreCredentialsValidLogin(selectedLogin, selectedPassword))
            {
                MessageBox.Show("�������� ����.");
                
                dbConnection.CloseConnection();
            }
            else
            {
                MessageBox.Show("�������� email ��� ������.");
                return;
            }
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxPassword.PasswordChar = '�';
            }

        }
    }
}

