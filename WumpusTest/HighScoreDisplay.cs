using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class HighScoreDisplay : Form
    {
        public HighScoreDisplay()
        {
            InitializeComponent();
        }

        private void ListOfHighScore_Click(object sender, EventArgs e)
        {

        }

        private void HighScoreDisplay_Load(object sender, EventArgs e)
        {
            HighScoreTitle.Parent = background;
            HighScoreTitle.BackColor = Color.Transparent;

            ListOfHighScore.Parent = background;
            ListOfHighScore.BackColor = Color.Transparent;

        }
    }
}
