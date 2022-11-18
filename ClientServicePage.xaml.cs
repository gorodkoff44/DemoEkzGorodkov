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
    /// Логика взаимодействия для ClientServicePage.xaml
    /// </summary>
    public partial class ClientServicePage : Page
    {
        private Client _currentClients = new Client();
        public ClientServicePage()
        {
            InitializeComponent();
            DataContext = _currentClients;
            ComboClient.ItemsSource = ToursBaseEntities.GetContext().Clients.ToList();
            //id.Text = _currentClients.ID.ToString();
        }

        private void Ref_Click(object sender, RoutedEventArgs e)
        {
            
            //id.Text = Clie
        }
    }
}
