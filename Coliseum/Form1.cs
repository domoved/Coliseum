using Coliseum.Entites;
using Coliseum.Models;

namespace Coliseum
{
    public partial class Form1 : Form
    {
        public Image helmerSheet;
        public Image dwarfSheet;
        public Entity player;
        public Form1()
        {
            InitializeComponent();
            Initialization();
        }
        public void Initialization()
        {   
            dwarfSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName.ToString(),"Sprites\\Dwarf.png"));
            player = new Entity(100,
                100,
                Hero.idleFrames,
                Hero.runFrames,
                Hero.attackFrames,
                Hero.deathFrames, dwarfSheet);
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {          
            Graphics g = e.Graphics;

            g.DrawImage(player.spriteSheet, new Rectangle(new Point(player.X, player.Y), new Size(player.size, player.size)), 0, 0, player.size, player.size, GraphicsUnit.Pixel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}