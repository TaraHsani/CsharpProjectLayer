using CsharpProject.Models;

namespace CsharpProject;


public partial class ProductForm : Form
{
    public ProductForm()
    {
        InitializeComponent();
    }

    public void saveButton_Click(object sender, EventArgs e)
    {

        try
        {



            if (string.IsNullOrEmpty(countLextBox.Text) || string.IsNullOrEmpty(priceTextBox.Text))
            {

                MessageBox.Show("Pleace inter a valid number");
                return;


            }

            Product product = new Product(Name: (nameTextBox.Text), price: decimal.Parse(priceTextBox.Text), count: int.Parse(countLextBox.Text));
        }
        catch (Exception ex)
        {


            MessageBox.Show(ex.Message);
                
                
        }
        //{
        //    product.Name = (nameTextBox.Text);
        //    product.Price = decimal.Parse(priceTextBox.Text);
        //    product.Count = int.Parse(countLextBox.Text);
        //    product.BrandName = (brandTextBox.Text);
        //    product.CreationDate = DateTime.Now;
        //};

        //var product2 = new Product()

        //{


        //    Name = (nameTextBox.Text),
        //    Price = decimal.Parse(priceTextBox.Text),
        //    Count = int.Parse(countLextBox.Text),
        //    BrandName = (brandTextBox.Text),
        //    //CreationDate = DateTime.Now,


    }

}
