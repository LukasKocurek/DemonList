using System;
using System.Data;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemonList
{
    public partial class TidalWave : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=userinfo2";
        private string currentUser;

        public TidalWave()
        {
            InitializeComponent();
        }

        public TidalWave(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void TidalWave_Load(object sender, EventArgs e)
        {
            if (IsLevelBeaten(currentUser, "Tidal Wave"))
            {
                Complete_TidalWave.FillColor = Color.Green;
                Leaderboard_header.Text = "Completed";
                Leaderboard_header.ForeColor = Color.Green;
            }
            else
            {
                Complete_TidalWave.FillColor = Color.Red;
            }

            LoadLeaderboardData();
        }

        private void LoadLeaderboardData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT 
                                    ROW_NUMBER() OVER (ORDER BY score DESC) AS rank,
                                    username,
                                    '100%' as score
                                FROM 
                                    leaderboard
                                WHERE 
                                    level = 'Tidal Wave';";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    TidalWaveGridView.DataSource = table;

                    TidalWaveGridView.Columns["username"].HeaderText = "Username";
                    TidalWaveGridView.Columns["score"].HeaderText = "Score";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BackButton_TidalWave_Click(object sender, EventArgs e)
        {
            new MainApp(currentUser).Show();
            this.Hide();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"768\" height=\"432\" src=\"{0}\"" +
                        "frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/9fsZ014qB3s";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void DemonListScoreNumber_TidalWave_Click(object sender, EventArgs e)
        {

        }

        private void Complete_TidalWave_Click(object sender, EventArgs e)
        {
            if (IsLevelBeaten(currentUser, "Tidal Wave"))
            {
                MessageBox.Show("Level already beaten!");
            }
            else
            {
                RecordScore(currentUser, "Tidal Wave", 350.00f);
                MessageBox.Show("Congratulations! You have completed Tidal Wave.");
                Complete_TidalWave.FillColor = Color.Green;

                Leaderboard_header.Text = "Completed";
                Leaderboard_header.ForeColor = Color.Green;
            }
        }

        private bool IsLevelBeaten(string username, string level)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM leaderboard WHERE username = @username AND level = @level";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@level", level);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void RecordScore(string username, string level, float score)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO leaderboard (username, level, score) VALUES (@username, @level, @score)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@level", level);
                    cmd.Parameters.AddWithValue("@score", score);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Score recorded successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to record score.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Leaderboard_header_Click(object sender, EventArgs e)
        {

        }

        private void TidalWaveGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tu môžete implementovať akcie, ktoré sa majú vykonať po kliknutí na bunku v DataGridView
            // Napríklad otvorenie nového okna s podrobnosťami o hráčovi alebo iné akcie
        }

        private void MovePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}