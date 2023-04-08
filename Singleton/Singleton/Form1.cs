using System.Diagnostics;

namespace Singleton
{
    public partial class Form1 : Form
    {
        string name;
        string lastName;
        int age;

        string path = "log.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Diverse");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            lastName = textBox2.Text;
            age = Convert.ToInt32(textBox3.Text);
            
            Logging logger = Logging.Initialize(name + " " + lastName + " ");
            logger.Log("launched the application");
            logger.Log("Entered age: " + age);
            logger.Log("Choose gender: " + comboBox1.Text);
            logger.Log("finished registration");

            MessageBox.Show("User registered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Process.Start("notepad.exe", path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, string.Empty);
        }
    }
}