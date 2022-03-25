using System.IO;
namespace Algoritmica_fundamentala
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

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader note = new StreamReader(@"../../TextFile1.txt");

            string t1 = note.ReadLine();
            string t2 = note.ReadLine();

            int n = int.Parse(t1);
            int[] v = new int[n];
            string[] t3 = t2.Split(' ');
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t3[i]);
                s += v[i];
            }

            listBox1.Items.Add(t1);
            listBox1.Items.Add(t2);
            listBox1.Items.Add(s);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}