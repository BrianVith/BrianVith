using MvvmHelpers;
using MvvmHelpers.Commands;
using MyCoffeeApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ObservableObject
    {
        public ObservableRangeCollection<string> Coffee { get; set; }

        public AsyncCommand RefreshCommand { get; }
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer);
            Coffee = new ObservableRangeCollection<string>();
        }
        public ICommand IncreaseCount { get; }
        public ICommand CallServerCommand { get; }

        int count = 0;

        private bool isBusy;

        async Task CallServer()
        {
            var items = new List<string> { "Yes plz", "Tonx", "Blue Bottle" };
            Coffee.AddRange(items);
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set => SetProperty(ref isBusy, value);
        }


        string countDisplay = "Click Me!";
        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
            //{
            //    if (value == countDisplay)
            //        return;

            //    countDisplay = value;
            //    //OnPropertyChanged("CountDisplay");
            //    //OnPropertyChanged(nameof(CountDisplay));
            //    OnPropertyChanged();
            //}
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} times";
        }
    }
}
