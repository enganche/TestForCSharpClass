using System.Text.RegularExpressions;

namespace Discord
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            HandleSignup();
        }

        private void HandleSignup()
        {
            string username = inputUsername.Text;
            string password = inputPassword.Text;
            string passwordRetype = inputRetype.Text;

            if (UsernameValidate(username)
                && PasswordValidate(password, passwordRetype))
            {
                lblTest.Text = "Success!";
            }
            else
            {
                lblTest.Text = "Please check again!";
            }
        }

        private bool UsernameValidate(string username)
        {
            string pattern = "^[A-Za-z0-9_]+$";

            Regex regexUsername = new Regex(pattern);

            if (regexUsername.IsMatch(username))
            {
                return true;
            }

            return false;
        }

        private bool PasswordValidate(string password, string passwordRetype)
        {
            if (password != passwordRetype)
            {
                return false;
            }

            string pattern = "^(?=.[0-9])(?=.[a-zA-Z])(?=.[!@#%^&()-+={}[]|/;:'<>,.?~]{8,}$";

            Regex regexPassword = new Regex(pattern);

            if (regexPassword.IsMatch(password) 
                && regexPassword.IsMatch(passwordRetype))
            {
                return true;
            }

            return false;
        }
    }
}