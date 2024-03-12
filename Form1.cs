using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const decimal CheesePizzaPrice = 8.00m;
        private const decimal PepperoniPizzaPrice = 9.00m;
        private const decimal VeggiePizzaPrice = 10.00m;
        private const decimal MeatPizzaPrice = 11.00m;

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cheeseQuantity = numericUpDown1.Value;
            decimal pepperoniQuantity = numericUpDown2.Value;
            decimal veggieQuantity = numericUpDown3.Value;
            decimal meatQuantity = numericUpDown4.Value;

            decimal totalPrice = 0;

            // Додавання вартості піц до загальної вартості
            if (checkBox1.Checked)
                totalPrice += CheesePizzaPrice * cheeseQuantity;
            if (checkBox2.Checked)
                totalPrice += PepperoniPizzaPrice * pepperoniQuantity;
            if (checkBox3.Checked)
                totalPrice += VeggiePizzaPrice * veggieQuantity;
            if (checkBox4.Checked)
                totalPrice += MeatPizzaPrice * meatQuantity;

            // Застосування знижки, якщо кількість замовлень більше 20
            decimal totalQuantity = cheeseQuantity + pepperoniQuantity + veggieQuantity + meatQuantity;
            if (totalQuantity > 20)
                totalPrice *= 0.9m; // 10% знижка

            // Виведення результату
            label1.Visible = true;
            label1.Text = $"Total:\n {totalPrice:C}";
        }
    }
}
