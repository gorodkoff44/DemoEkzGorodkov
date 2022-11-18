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
    /// Логика взаимодействия для ViewService.xaml
    /// </summary>
    public partial class ViewService : Page
    {
        private Service _currentService = new Service();
        public ViewService(Service selectedService)
        {
            InitializeComponent();
            DataContext = _currentService;
            if (selectedService != null)
                _currentService = selectedService;
            DataContext = _currentService;
        }
    }
}
