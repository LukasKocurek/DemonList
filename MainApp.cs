using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DemonList
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private string currentUser;

        public MainApp(string user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void MainApp_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LevelLabel_TidalWave_Click(object sender, EventArgs e)
        {
         
        }

        private void RulesLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button_TidalWave_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Avernus_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new TidalWave(currentUser).Show(); // Prenášame currentUser do okna TidalWave
            this.Hide();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new Avernus(currentUser).Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            new Acheron(currentUser).Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new SilentClubstep(currentUser).Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            new AbyssOfDarkness(currentUser).Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            new Kyouki(currentUser).Show();
            this.Hide();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            new Slaughterhouse(currentUser).Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            new SakupenCircles(currentUser).Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new TunnelOfDespair(currentUser).Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            new KOCMOC(currentUser).Show();
            this.Hide();
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void leaderboard_button_Click(object sender, EventArgs e)
        {
            new Leaderboard(currentUser).Show();
            this.Hide();
        }

        private void rules_button_Click(object sender, EventArgs e)
        {
            new Rules(currentUser).Show();
            this.Hide();
        }

        private void guna2Panel23_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
