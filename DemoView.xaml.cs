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
    /// Логика взаимодействия для DemoView.xaml
    /// </summary>
    public partial class DemoView : Page
    {
        private Service _currentService = new Service();
        public DemoView(Service selectedService)
        {
            InitializeComponent();
            DataContext = _currentService;
            if (selectedService != null)
                _currentService = selectedService;
            DataContext = _currentService;
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var ServiceForRemoving = _currentService;
            if (MessageBox.Show($"Вы точно хотите удалить {ServiceForRemoving}?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ToursBaseEntities.GetContext().Services.RemoveRange((IEnumerable<Service>)ServiceForRemoving);
                    ToursBaseEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
