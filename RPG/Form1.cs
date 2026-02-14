namespace RPG
{
    public partial class Form1 : Form
    {
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
            //Selection de zone
            switch (e.KeyData)
            {
                case Keys.D1:
                    break;
                case Keys.D2:
                    break;
                case Keys.D3:
                    break;
                case Keys.D4:
                    break;
            }
        }
    }
}
