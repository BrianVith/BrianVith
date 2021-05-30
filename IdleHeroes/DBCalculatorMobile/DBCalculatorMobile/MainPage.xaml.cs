using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DBCalculatorMobile
{
    public partial class MainPage : ContentPage
    {
        public bool IsInteger { get; set; }
        public int Total { get; set; }

        public MainPage()
        {
            InitializeComponent();
            IsInteger = false;
        }

        private void btnCalculate_Clicked(object sender, EventArgs e)
        {
            Total = 0;
            OrbsCalc();
            ShadowCalc();
            JahraCheck();
            lbTotalPoints.Text = Total.ToString();

            if (Total >= 100)
            {
               // tbDBTime.Visibility = Visibility.Visible;
            }
            else
            {
                //tbDBTime.Visibility = Visibility.Hidden;
            }
        }

        private void OrbsCalc()
        {
            int orbs, count;
            if (entOrbs == null)
            {
                orbs = 0;
                entOrbs.Text = "0";
            }
            else
            {
                IsInteger = int.TryParse(entOrbs.Text, out orbs);
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
                                if (orbs > 100)
                                {
                                    orbs = 100;
                                    entOrbs.Text = "300";
                                }
                                Total += orbs;
                                break;
                            }
                            else
                                orbs--;
                        }
                    }
                }
                else
                    entOrbs.Text = "0";
            }
        }

        private void ShadowCalc()
        {
            int shadowSummons;
            IsInteger = int.TryParse(entShadowSummon.Text, out shadowSummons);
            if (IsInteger)
            {
                if (shadowSummons > 30)
                {
                    shadowSummons = 30;
                    entShadowSummon.Text = "30";
                }
                Total += shadowSummons;
            }
            else
                entShadowSummon.Text = "0";

        }

        private void JahraCheck()
        {
            if (cb5StarJahra.IsChecked)
                Total += 5;
            if (cb6StarJahra.IsChecked)
                Total += 5;
            if (cb10StarJahra.IsChecked)
                Total += 10;
        }


    }


}
