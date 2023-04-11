namespace Builder
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var builder = new MonitorBuilder();

            var director = new Director(builder);

            director.Build((string)textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

            var monitor = builder.GetMonitor();

            var monitor2 = monitor.Clone();

            richTextBox1.Text = monitor.ToString()+Environment.NewLine+monitor2.ToString()+Environment.NewLine+monitor.GetHashCode()+ Environment.NewLine + monitor2.GetHashCode();
        }
    }
}