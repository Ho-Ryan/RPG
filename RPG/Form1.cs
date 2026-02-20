using System.DirectoryServices.ActiveDirectory;
using static System.Windows.Forms.DataFormats;

namespace RPG
{
    public partial class Form1 : Form
    {
        public bool InAction = false;

        public Ennemy ennemies = new Ennemy();
        //public Ennemy Ennemies
        //{
        //    get { return ennemies; }
        //    set { ennemies = value; }
        //}
        public Player player = new Player();
        //public Player Player
        //{
        //    get { return player; }
        //    set { player = value; }
        //}
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Action.Text = "1) Shop\n2) Forêt\n";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Selection de zone
            if (!InAction)
            {
                switch (e.KeyData)
                {
                    case Keys.D1:
                        Shop();
                        break;
                    case Keys.D2:
                        Forest foret = new Forest(player, ennemies);
                        foret.ShowDialog();
                        break;
                    case Keys.D3:
                        break;
                    case Keys.D4:
                        break;
                }
                if (e.KeyData == Keys.Enter)
                {
                    player.ShowStats();
                }
            }
        }



        public void Shop()
        {
            Events.Text += ("Vous entrez dans un shop\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.LvUp();
        }
    }
}
