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

namespace WpfLogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainWindow()
        {
            InitializeComponent();

            //XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            log.Info("info testing");
            log.Debug("debug testing");
            log.Error("error testing");
            log.Fatal("fatal testing");
            log.Warn("warn testing");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLog.Text))
            {
                log.Info(txtLog.Text);
                MessageBox.Show($"{txtLog.Text} Logged Successfully.");
            }
        }
    }
}
