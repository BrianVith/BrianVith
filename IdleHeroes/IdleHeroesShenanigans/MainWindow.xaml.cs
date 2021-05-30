using System.Windows;

namespace IdleHeroesShenanigans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsInteger { get; set; }
        public int Total { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            IsInteger = false;
        }

        private void OrbsCalc()
        {
            int orbs, count;
            if (tbOrbs.Text.Length == 0)
            {
                orbs = 0;
                tbOrbs.Text = "0";
            }
            else
            {
                IsInteger = int.TryParse(tbOrbs.Text, out orbs);
                if (IsInteger)
                {
                    if (orbs >= 3)
                    {
                        count = orbs;
                        for (int i = 0; i < count; i--)
                        {
                            if ((orbs % 3) == 0)
                            {
                                orbs = orbs / 3;
                                Total += orbs;
                                break;
                            }
                            else
                                orbs--;
                        }
                    }
                }
                else
                    tbOrbs.Text = "0";
            }
        }

        private void ShadowCalc()
        {
            int shadowSummons;
            IsInteger = int.TryParse(tbShadowSummon.Text, out shadowSummons);
            if (IsInteger)
            {
                if (shadowSummons > 30)
                {
                    shadowSummons = 30;
                    tbShadowSummon.Text = "30";
                }
                Total += shadowSummons;
            }
            else           
                tbShadowSummon.Text = "0";
            
        }

        private void JahraCheck()
        {
            if (cb5StarJahra.IsChecked.Value)          
                Total += 5;           
            if (cb6StarJahra.IsChecked.Value)
                Total += 5;            
            if (cb10StarJahra.IsChecked.Value)           
                Total += 10;         
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            Total = 0;
            OrbsCalc();
            ShadowCalc();
            JahraCheck();
            tbTotal.Text = Total.ToString();

            if (Total >= 100)           
                tbDBTime.Visibility = Visibility.Visible;           
            else            
                tbDBTime.Visibility = Visibility.Hidden;            
        }
    }
}
