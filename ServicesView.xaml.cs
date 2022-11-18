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
    /// Логика взаимодействия для ServiceView.xaml
    /// </summary>
    public partial class ServiceView : Page
    {
        public ServiceView()
        {
            InitializeComponent();
            DGridServices.ItemsSource = ToursBaseEntities.GetContext().Services.ToList();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
                NavigationService.Navigate(new EditPage((sender as Button).DataContext as Service));
        }


        private void del_Click(object sender, RoutedEventArgs e)
        {
            var ServiceForRemoving = DGridServices.SelectedItems.Cast<Service>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {ServiceForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ToursBaseEntities.GetContext().Services.RemoveRange(ServiceForRemoving);
                    ToursBaseEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridServices.ItemsSource = ToursBaseEntities.GetContext().Services.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //if (Visibility == Visibility.Visible)
            //{
            //    ToursBaseEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            //    DGridServices.ItemsSource = ToursBaseEntities.GetContext().Clients.ToList();
            //}
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddServiceView.xaml", UriKind.Relative));
        }
    }
}
