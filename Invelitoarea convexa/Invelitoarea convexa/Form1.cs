namespace Invelitoarea_convexa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int x, y;
        Random rnd = new Random();
        Point P = new Point();
        List<int> Lstx = new List<int>();
        List<int> Lsty = new List<int>();
        List<Point> list = new List<Point>();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen c = new Pen(Color.Red, 4);
            Pen p = new Pen(Color.Black, 2);
            int n = 50;
            for (int i = 0; i < n; i++)
            {
                x = rnd.Next(100,500);
                y = rnd.Next(100,500);
                P.X = x;
                P.Y = y;
                list.Add(P);
                g.DrawEllipse(c, x, y, 2, 2);
            }
            list.Sort();
        }
    }
}