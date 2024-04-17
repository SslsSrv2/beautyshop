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
using WpfApp4.AppDataFile;
using WpfApp4.AppDataFile.Pages;
using WpfApp4.Pages;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectObj.conObj = new BeautyShop2Entities();
            FrameObf.fraimeMain = FrameMain;
            FrameMain.Navigate(new PageLogin());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrameMain.GoBack();
            }
            catch (Exception)
            {
               MessageBox.Show("Невозможно вернуться");
            }
        }
        private void btnFaq_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new PageProduct());
        }
    }
}
