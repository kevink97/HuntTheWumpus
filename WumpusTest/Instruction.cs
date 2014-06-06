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
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void Instruction_Load(object sender, EventArgs e)
        {
            title.Parent = background;
            title.BackColor = Color.Transparent;
            text.Parent = background;
            text.BackColor = Color.Transparent;
            text.Text = "This is pretty much hide and seek. \nYou try to shoot the shark. \nif you find it tho...it will run away.\nbe careful of bats and pits, especially pits!";
        }
    }
}
