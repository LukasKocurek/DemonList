using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemonList
{
    public partial class Rules : Form
    {
        private string currentUser;

        public Rules()
        {
            InitializeComponent();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        public Rules(string currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Leaderboard_Click(object sender, EventArgs e)
        {
            new MainApp(currentUser).Show();
            this.Hide();
        }
    }
}
