using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Firebase.Database;

namespace KidneyCare
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            var auth = "B2yknvjMYx8GIUsA0eBEnDTyYN3FYy6Rzyujc8cY"; // your app secret
            var firebaseClient = new FirebaseClient(
              "<https://console.firebase.google.com/project/kidenycare/database/firestore/data~2F>",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              });
            InitializeComponent();
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
            if (loginText.Text == "User Name")
            {
                loginText.Text = "";
            }

            loginText.ForeColor = Color.Black;
            
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == "Password")
            {
                passwordText.Text = "";
            }

            passwordText.ForeColor = Color.Black;
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
            if (loginText.Text == "" || loginText.Text == null)
            {
                loginText.Text = "User Name";
                loginText.ForeColor = SystemColors.InactiveCaption;
            }

            
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "" || passwordText.Text == null)
            {
                passwordText.Text = "Password";
                passwordText.ForeColor = SystemColors.InactiveCaption;
            }
        }
    }
}
