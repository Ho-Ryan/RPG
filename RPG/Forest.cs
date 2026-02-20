using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Forest : Form
    {
        Player _player;
        Ennemy _ennemies;
        public Forest(Player player, Ennemy ennemies)
        {
            _player = player;
            _ennemies = ennemies;
            InitializeComponent();
        }

        private void Forest_Load(object sender, EventArgs e)
        {

        }

        private void Forest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D1)
            {
                _player.Experience += 10000;
            }
            if (e.KeyData == Keys.Enter)
            {
                _player.ShowStats();
            }

            if (e.KeyData == Keys.Escape)
            {
                
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _player.LvUp();
        }
    }
}
