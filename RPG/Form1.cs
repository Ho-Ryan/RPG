namespace RPG
{
    public partial class Form1 : Form
    {
        public bool InAction = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Player player = new Player();
            Ennemy ennemies = new Ennemy();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Selection de zone$
            if (!InAction)
            {
                switch (e.KeyData)
                {
                    case Keys.D1:
                        Shop();
                        break;
                    case Keys.D2:
                        InAction = true;
                        Forest();
                        break;
                    case Keys.D3:
                        break;
                    case Keys.D4:
                        break;
                }
            }
        }

        public void Forest()
        {
            Events.Text += ("Vous aller dans la forêt\n");

        }

        public void Shop()
        {
            Events.Text += ("Vous entrez dans un shop\n");
        }
    }
}
