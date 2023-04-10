namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedPizza = comboBox1.SelectedItem.ToString();

            PizzaFactory pizzaFactory;
            switch (selectedPizza)
            {
                case "Cheese":
                    pizzaFactory = new CheesePizzaFactory();
                    break;
                case "Pepperoni":
                    pizzaFactory = new PepperoniPizzaFactory();
                    break;
                case "Barbecue":
                    pizzaFactory = new BarbecuePizzaFactory();
                    break;
                default:
                    MessageBox.Show("Please select a valid pizza.");
                    return;
            }

            Pizza pizza = pizzaFactory.CreatePizza();
            richTextBox1.Text = pizza.GetDescription();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cheese");
            comboBox1.Items.Add("Pepperoni");
            comboBox1.Items.Add("Barbecue");
        }
    }
}