using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Module_1._1_Exercise_14_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product
            {
                NameProduct = "Apple",
                CostProduct = 20,
                TypeProduct = TypesProduct.Food,
                ImagePath = "Путь к Apple"
            });
            products.Add(new Product
            {
                NameProduct = "WachMachine",
                CostProduct = 50000,
                TypeProduct = TypesProduct.HomeTechnology,
                ImagePath = "Путь к WachMachine"
            });
            products.Add(new Product
            {
                NameProduct = "Bread",
                CostProduct = 30,
                TypeProduct = TypesProduct.Food,
                ImagePath = "Путь к Bread"
            });
            lstBox.ItemsSource = products;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product
            {
                NameProduct = "Banana",
                CostProduct = 40,
                TypeProduct = TypesProduct.Food,
                ImagePath = "Путь к Banana"
            });
        }
    }
}
