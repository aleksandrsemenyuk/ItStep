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
using System.Diagnostics;

namespace ThreadManip
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Process myProcess = new Process();
        public MainWindow()
        {
            InitializeComponent();
            myProcess.StartInfo.FileName="calc.exe";
         

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            myProcess.Start();
            tbInfo.Text = Environment.NewLine;
            tbInfo.Text = Environment.NewLine;
            tbInfo.Text = "Запущений процес";
            tbInfo.Text = Environment.NewLine;
            myProcess.WaitForExit();
            tbInfo.Text = "Завешений процес";
        }
    }
}
