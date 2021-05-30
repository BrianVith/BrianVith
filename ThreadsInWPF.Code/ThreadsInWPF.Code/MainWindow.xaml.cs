using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace ThreadsInWPF.Code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPutIn1_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                var fruit = (lbFruits.SelectedItem as ListBoxItem).Content;
                lbBlender1.Items.Add(new ListBoxItem { Content = fruit });
            }
        }

        private void BtnPutIn2_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                var fruit = (lbFruits.SelectedItem as ListBoxItem).Content;
                lbBlender2.Items.Add(new ListBoxItem { Content = fruit });
            }
        }

        private void BtnBlend1_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(Blend1);
            thread.Start();
        }

        private void BtnBlend2_Click(object sender, RoutedEventArgs e)
        {

            Thread thread = new Thread(Blend2);
            thread.Start();
        }

        private void Blend1()
        {
            btnBlend1.Dispatcher.Invoke(new Action(() => btnBlend1.IsEnabled = false));
            btnClean1.Dispatcher.Invoke(new Action(() => btnClean1.IsEnabled = false));
            int blendTime = 10;
            for (int i = 0; i < blendTime; i++)
            {
                Dispatcher.Invoke(new Action(() => lblStatus1.Text = $"Blending {i}"), DispatcherPriority.Normal, null);
                Dispatcher.Invoke(new Action(() => pbStatus1.Value = i+1));
                //lblStatus1.Content = $"Blending {i}";
                Thread.Sleep(1000);
            }
            lblStatus1.Dispatcher.Invoke(new Action(() => lblStatus1.Text = "Juice Ready"), DispatcherPriority.Normal, null);
            btnBlend1.Dispatcher.Invoke(new Action(() => btnBlend1.IsEnabled = true));
            btnClean1.Dispatcher.Invoke(new Action(() => btnClean1.IsEnabled = true));
        }

        private void Blend2()
        {
            btnClean2.Dispatcher.Invoke(new Action(() => btnClean2.IsEnabled = false));
            btnBlend2.Dispatcher.Invoke(new Action(() => btnBlend2.IsEnabled = false));
            int blendTime = 10;
            for (int i = 0; i < blendTime; i++)
            {
                lblStatus2.Dispatcher.Invoke(new Action(() => lblStatus2.Text = $"Blending {i}"));
                lblStatus2.Dispatcher.Invoke(new Action(() => pbStatus2.Value = i+1));
                //lblStatus2.Content = $"Blending {i}";
                Thread.Sleep(1000);
            }
            lblStatus2.Dispatcher.Invoke(new Action(() => lblStatus2.Text = "Juice Ready"));
            btnBlend2.Dispatcher.Invoke(new Action(() => btnBlend2.IsEnabled = true));
            btnClean2.Dispatcher.Invoke(new Action(() => btnClean2.IsEnabled = true));
        }

        private void btnClean1_Click(object sender, RoutedEventArgs e)
        {
            lbBlender1.Items.Clear();
            lblStatus1.Text = "Cleaned";
            pbStatus1.Value = 0;
        }
        private void btnClean2_Click(object sender, RoutedEventArgs e)
        {
            lbBlender2.Items.Clear();
            lblStatus2.Text = "Cleaned";
            pbStatus2.Value = 0;
        }
    }
}
