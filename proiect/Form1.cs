using System.Threading.Tasks.Dataflow;

namespace proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apasa.BackColor = Color.Pink;
            MessageBox.Show("ai apasat");
        }
    }
}
