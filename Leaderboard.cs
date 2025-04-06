using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemonList
{
    public partial class Leaderboard : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=userinfo2";
        private string currentUser;

        public Leaderboard()
        {
            InitializeComponent();
        }

        public Leaderboard(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            LoadLeaderboardData();
        }

        private void LoadLeaderboardData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            (SELECT COUNT(*) 
                             FROM (SELECT DISTINCT username, ROUND(SUM(score), 3) AS total_score 
                                   FROM leaderboard 
                                   GROUP BY username 
                                   ORDER BY total_score DESC) AS sub 
                             WHERE total_score >= t.total_score) AS rank,
                            t.username,
                            ROUND(t.total_score, 3) AS total_score
                        FROM (SELECT DISTINCT username, ROUND(SUM(score), 3) AS total_score 
                              FROM leaderboard 
                              GROUP BY username 
                              ORDER BY total_score DESC) AS t;
                           ";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    guna2DataGridView1.DataSource = table;

                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = ">";
                    buttonColumn.Text = ">";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    buttonColumn.Name = "View Levels"; 
                    guna2DataGridView1.Columns.Add(buttonColumn);

                    guna2DataGridView1.Columns["username"].HeaderText = "Username";
                    guna2DataGridView1.Columns["total_score"].HeaderText = "Total Score";

                    guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Leaderboard_Click(object sender, EventArgs e)
        {
            new MainApp(currentUser).Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == guna2DataGridView1.Columns["View Levels"].Index)
            {
                string username = guna2DataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();

                ShowPlayerLevels(username);
            }
        }

        private void ShowPlayerLevels(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT level FROM leaderboard WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    string levels = "";
                    foreach (DataRow row in table.Rows)
                    {
                        levels += row["level"].ToString() + Environment.NewLine;
                    }

                    MessageBox.Show($"Levels for player {username}:\n{levels}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void leftBackground_Paint(object sender, EventArgs e)
        {

        }
        private void guna2DataGridView1_CellContentClick(object sender, EventArgs e)
        {
 
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}