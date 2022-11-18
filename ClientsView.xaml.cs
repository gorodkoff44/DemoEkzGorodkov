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
    /// Логика взаимодействия для ClientsView.xaml
    /// </summary>
    public partial class ClientsView : Page
    {
        public ClientsView()
        {
            InitializeComponent();
            DGridClient.ItemsSource = ToursBaseEntities.GetContext().Clients.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
                var ClientForRemoving = DGridClient.SelectedItems.Cast<Client>().ToList();
                if (MessageBox.Show($"Вы точно хотите удалить следующие {ClientForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        ToursBaseEntities.GetContext().Clients.RemoveRange(ClientForRemoving);
                        ToursBaseEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");
                        DGridClient.ItemsSource = ToursBaseEntities.GetContext().Clients.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
