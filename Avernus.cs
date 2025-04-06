using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemonList
{
    public partial class Avernus : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=userinfo2";
        private string currentUser;

        public Avernus()
        {
            InitializeComponent();
        }

        public Avernus(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"768\" height=\"432\" src=\"{0}\"" + // Zväčšenie veľkosti videa
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/16Zh8jssanc"; // Použite odkaz na embed videa
            this.webBrowser1.DocumentText = string.Format(embed, url);

            // Skontrolujeme, či užívateľ už dokončil level pri načítaní formulára
            if (IsLevelBeaten(currentUser, "Avernus"))
            {
                Complete_Avernus.FillColor = Color.Green;
                Leaderboard_header.Text = "Completed";
                Leaderboard_header.ForeColor = Color.Green;
            }

            // Načítame údaje do DataGridView
            LoadLeaderboardData();
        }

        private void Avernus_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void BackButton_Avernus_Click_1(object sender, EventArgs e)
        {
            new MainApp(currentUser).Show();
            this.Hide();
        }

        private void Complete_Avernus_Click(object sender, EventArgs e)
        {
            // Kontrola, či bol level už prejdený
            if (IsLevelBeaten(currentUser, "Avernus"))
            {
                MessageBox.Show("Level already beaten!"); // Zobrazíme správu, že level už bol prejdený
            }
            else
            {
                // Zaznamenanie prejdenia levelu a pripočítanie bodov
                RecordScore(currentUser, "Avernus", 337.71f); // Zmeníme skóre na "100%"
                MessageBox.Show("Congratulations! You have completed Avernus."); // Zobrazíme hlásenie, že užívateľ dokončil level

                // Zmena farby a textu tlačidla a labelu po prejdení levelu
                Complete_Avernus.FillColor = Color.Green;
                Leaderboard_header.Text = "Completed";
                Leaderboard_header.ForeColor = Color.Green;

                // Aktualizujeme zobrazenie údajov v tabuľke
                LoadLeaderboardData();
            }
        }

        private bool IsLevelBeaten(string username, string level)
        {
            // Kontrola, či bol level už prejdený
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
                // Pripojenie k databáze
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Vloženie záznamu do tabuľky leaderboard
                    string query = "INSERT INTO leaderboard (username, level, score) VALUES (@username, @level, @score)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@level", level);
                    cmd.Parameters.AddWithValue("@score", score);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Záznam úspešne vložený do tabuľky leaderboard
                        MessageBox.Show("Score recorded successfully!");
                    }
                    else
                    {
                        // Niečo sa pokazilo pri vkladaní záznamu do tabuľky leaderboard
                        MessageBox.Show("Failed to record score.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Chyba pri pripájaní k databáze alebo pri vykonávaní SQL príkazu
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Leaderboard_header_Click(object sender, EventArgs e)
        {

        }

        private void AvernusGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                                    level = 'Avernus';";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    AvernusGridView.DataSource = table;

                    AvernusGridView.Columns["rank"].HeaderText = "Rank";
                    AvernusGridView.Columns["username"].HeaderText = "Username";
                    AvernusGridView.Columns["score"].HeaderText = "Score";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Creator_Avernus_Click (object sender, EventArgs e)
        {

        }
    }
}