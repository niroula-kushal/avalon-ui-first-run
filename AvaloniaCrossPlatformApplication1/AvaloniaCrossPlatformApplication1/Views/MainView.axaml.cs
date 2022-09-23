using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaCrossPlatformApplication1.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            Calendar.SelectedDate = DateTime.Now;
        }

        private void Calendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine((sender as Calendar).SelectedDate);
        }

        private void MinusDay(object sender, RoutedEventArgs e)
        {
            Calendar.SelectedDate = Calendar.SelectedDate?.AddDays(-1);
        }

        private void AddDay(object sender, RoutedEventArgs e)
        {
            Calendar.SelectedDate = Calendar.SelectedDate?.AddDays(1);
        }
    }
}