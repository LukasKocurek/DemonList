﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemonList
{
    public partial class TunnelOfDespair : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=userinfo2";
        private string currentUser;

        public TunnelOfDespair()
        {
            InitializeComponent();
        }

        public TunnelOfDespair(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void TunnelOfDespair_Load(object sender, EventArgs e)
        {
            LoadLeaderboardData();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"768\" height=\"432\" src=\"{0}\"" + // Zväčšenie veľkosti videa
                        "frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/LpS4JREhW98"; // Použite odkaz na embed videa
            this.webBrowser1.DocumentText = string.Format(embed, url);

            // Skontrolujeme, či užívateľ už dokončil level pri načítaní formulára
            if (IsLevelBeaten(currentUser, "Tunnel of Despair"))
            {
                Complete_TOD.FillColor = Color.Green;
                Leaderboard_header.Text = "Completed";
                Leaderboard_header.ForeColor = Color.Green;
            }
        }

        private void BackButton_TOD_Click(object sender, EventArgs e)
        {
            new MainApp(currentUser).Show();
            this.Hide();
        }

        private void Complete_TOD_Click(object sender, EventArgs e)
        {
            // Kontrola, či bol level už prejdený
            if (IsLevelBeaten(currentUser, "Tunnel of Despair"))
            {
                MessageBox.Show("Level already beaten!"); // Zobrazíme správu, že level už bol prejdený
            }
            else
            {
                // Zaznamenanie prejdenia levelu a pripočítanie bodov
                RecordScore(currentUser, "Tunnel of Despair", 207.42f); // Použijeme currentUser ako používateľské meno
                MessageBox.Show("Congratulations! You have completed Tunnel of Despair."); // Zobrazíme hlásenie, že užívateľ dokončil level

                // Zmena farby a textu tlačidla a labelu po prejdení levelu
                Complete_TOD.FillColor = Color.Green;
                Leaderboard_header.Text = "Completed";
                Leaderboard_header.ForeColor = Color.Green;

                // Aktualizácia tabuľky leaderboard po prejdení levelu
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
                                        level = 'Tunnel of Despair';";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    TunnelofDespairGridView.DataSource = table;

                    TunnelofDespairGridView.Columns["rank"].HeaderText = "Rank";
                    TunnelofDespairGridView.Columns["username"].HeaderText = "Username";
                    TunnelofDespairGridView.Columns["score"].HeaderText = "Score";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TunnelofDespairGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}