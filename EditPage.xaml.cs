using System;
using System.Collections.Generic;
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

namespace DemoEkzGorodkov
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Service _currentService = new Service();
        public EditPage(Service selectedService)
        {
            InitializeComponent();
            DataContext = _currentService;
            if (selectedService != null)
                _currentService = selectedService;
            DataContext = _currentService;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToursBaseEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные внесены");
                NavigationService.GoBack();
                //NavigationService.Navigate(new Uri("/ServicesView.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
                return;
            }
        }
    }
}
