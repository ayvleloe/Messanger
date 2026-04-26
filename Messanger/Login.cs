using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        public List<Accounts> accountsListLogin { get; set; }
        public Accounts currentUserLogin { get; set; }

        public event EventHandler WechselZuRegistration;

        Registration registrationFenster;


        private void Login_Load(object sender, EventArgs e)
        {

        }

        public bool VerifyPasswordArgon2id(string password, byte[] storedSalt, byte[] storedHash) // HASHING
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = storedSalt,
                Iterations = 3,
                MemorySize = 65536,
                DegreeOfParallelism = 2
            };

            byte[] computedHash = argon2.GetBytes(32);

            return FixedTimeEquals(computedHash, storedHash);
        }

        bool FixedTimeEquals(byte[] a, byte[] b) // HASHING
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }

            return diff == 0;
        }

        void LoginInAccount()
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPasswordLogin.Text;

            Accounts user = accountsListLogin.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("Falscher Username oder Password");
                return;
            }

            bool passwordOk = VerifyPasswordArgon2id(password, user.PasswordSalt, user.PasswordHash);

            if (!passwordOk)
            {
                MessageBox.Show("Falscher Username oder Password");
            }
            else
            {
                currentUserLogin = user;

            }
                
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            WechselZuRegistration?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxPasswordLogin.UseSystemPasswordChar = false;
        }

        private void ButtonPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TextBoxPasswordLogin.UseSystemPasswordChar = true;
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            LoginInAccount();
        }
    }
}
