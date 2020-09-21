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

namespace CS_ASP_016CalControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

       // private void MonthlyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e) { }
        private void MonthlyCalendar_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e) { }
        private void MonthlyCalendar_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e) { }


        // this is where I was getting this code. 
        // https://www.c-sharpcorner.com/UploadFile/mahesh/wpf-calendar-control/


        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void MonthlyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            label.Content = MonthlyCalendar.SelectedDate.ToString();


        }

        private void Tom_Click(object sender, RoutedEventArgs e)
        {


            //string dateInput = "Jan 1, 2009";
            //var parsedDate = DateTime.Parse(dateInput);


            //DateTime missionStart = MonthlyCalendar.SelectedDate.GetValueOrDefault();

            //DateTime MissionEnd = missionStart.AddDays(14);

            DateTime myTime = new DateTime(2020, 9, 1);

            DateTime nextTime = new DateTime(2020, 9, 4);



            SetBlackOutDates(myTime, nextTime);





        }


        private void SetBlackOutDates(DateTime missionStart, DateTime MissionEnd)
        {
             MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(missionStart, MissionEnd));

           // MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(new DateTime(date), new DateTime(2010, 3, 7)));
           // MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(new DateTime(2010, 3, 8), new DateTime(2010, 3, 8)));
            //MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(new DateTime(2010, 3, 15), new DateTime(2010, 3, 15)));
            //MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(new DateTime(2010, 3, 22), new DateTime(2010, 3, 22)));
            //MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(new DateTime(2010, 3, 29), new DateTime(2010, 3, 29)));
        }



    }
}
