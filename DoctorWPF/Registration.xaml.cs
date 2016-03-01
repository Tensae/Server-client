﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DoctorWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Client c = new Client();
        public Registration()
        {
            InitializeComponent();
        }

        private void submit_click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email!";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch
                (textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                string username = textBoxUsername.Text;
                string email = textBoxEmail.Text;
                int age = Convert.ToInt32(textBoxAge.Text);
                string password = passwordBox1.Password;
                if (passwordBox1.Password.Length == 0)
                {
                    errormessage.Text = "Enter password.";
                    passwordBox1.Focus();
                }
                else if (passwordBoxConfirm.Password.Length == 0)
                {
                    errormessage.Text = "Enter confirm password";
                    passwordBoxConfirm.Focus();
                }
                else if (passwordBox1.Password != passwordBoxConfirm.Password)
                {
                    errormessage.Text = "Confirm password must be same as password";
                    passwordBoxConfirm.Focus();
                }
                else if (!c.CheckLogin(textBoxEmail.Text))
                {
                    DoctorEntities1 db = new DoctorEntities1();

                    User u = new User();

                    u.UserName = username;
                    u.Email = email;
                    u.Age = age;
                    u.Password = password;

                    db.User.Add(u);
                    db.SaveChanges();
                }
                else
                {

                }
                Journal j = new Journal();
                j.Show();
                this.Close();
            }
        }

        private void cancel_click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
