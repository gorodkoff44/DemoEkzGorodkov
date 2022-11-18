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
    /// Логика взаимодействия для AddServiceView.xaml
    /// </summary>
    public partial class AddServiceView : Page
    {
        private Service _currentService = new Service();
        public AddServiceView()
        {
            InitializeComponent();
            try
            {
                DataContext = _currentService;
            }
            catch
            {
                MessageBox.Show("Нет соединения с базой данных!");
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            ToursBaseEntities.GetContext().Services.Add(_currentService);
            try
            {
                ToursBaseEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
