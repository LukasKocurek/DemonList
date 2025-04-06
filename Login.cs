using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemonList
{
    public partial class LoginForm : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=userinfo2";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MovePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string regUsername = RegisterName.Text.Trim().ToLower();
            string regPassword1 = RegisterPassword1.Text.Trim();
            string regPassword2 = RegisterPassword2.Text.Trim();

            if (regUsername == "" || regPassword1 == "" || regPassword2 == "")
            {
                MessageBox.Show("Every information is required!");
                return;
            }
            else if (regPassword1 != regPassword2)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            else
            {
                // Vykonanie registracie
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string checkQuery = "SELECT COUNT(*) FROM register WHERE LOWER(username) = @regUname";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                        checkCmd.Parameters.AddWithValue("@regUname", regUsername);
                        int existingUserCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingUserCount > 0)
                        {
                            MessageBox.Show("Username already exists! Please choose a different username.");
                            return;
                        }

                        
                        string query = "INSERT INTO register (username, password) VALUES (@regUname, @regPass)";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@regUname", regUsername);
                        cmd.Parameters.AddWithValue("@regPass", regPassword1);

                        int status = cmd.ExecuteNonQuery();

                        if (status > 0)
                        {
                            MessageBox.Show("Account Created Successfully!");

                            
                            RegisterName.Text = "";
                            RegisterPassword1.Text = "";
                            RegisterPassword2.Text = "";

                            connection.Close();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string logUsername = LoginName.Text.Trim().ToLower();
            string logPassword = LoginPassword.Text.Trim();

            if (logUsername == "" || logPassword == "")
            {
                MessageBox.Show("Username and Password are required!");
                return;
            }
            else
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    using (connection)
                    {
                        connection.Open();
                        string query = "SELECT username, password FROM register WHERE LOWER(username) = @logUname AND password=@logPass LIMIT 1";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@logUname", logUsername);
                        cmd.Parameters.AddWithValue("@logPass", logPassword);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            connection.Close();
                            new MainApp(logUsername).Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Invalid login details");
                            connection.Close();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void LoginPassword_TextChanged(object sender, EventArgs e)
        {
            LoginPassword.UseSystemPasswordChar = true;
        }

        private void RegisterPassword1_TextChanged(object sender, EventArgs e)
        {
            RegisterPassword1.UseSystemPasswordChar = true;
        }

        private void RegisterPassword2_TextChanged(object sender, EventArgs e)
        {
            RegisterPassword2.UseSystemPasswordChar = true;
        }

        private void RegisterName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
