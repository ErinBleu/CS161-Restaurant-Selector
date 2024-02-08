namespace RestaurantSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double vegetarian;
            double vegan;
            double glutenFree;
            vegetarian = 0;
            vegan = 0;
            glutenFree = 0;

            if (vegetarian > 0)
            {
                restaurantsLabel.Text = "Main Street Pizza Company";
            }
        }

        private void choicescheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choicescheckedList.SelectedIndex == 1)
            {
                restaurantsLabel.Text = "Main Street Pizza Company";
            }

        }
    }
}
