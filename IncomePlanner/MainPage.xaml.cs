using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IncomePlanner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SubmitBtn_Clicked(object sender, EventArgs e)
        {
            _ = label.RelRotateTo(360, 1000);
            var expenseVal = double.Parse(expenses.Text);
            var perHourVal = double.Parse(perHour.Text);
            var hoursVal = double.Parse(hours.Text);
            var overtimeVal = double.Parse(overtime.Text);

            var total = (perHourVal * hoursVal) + overtimeVal - expenseVal;

            label.Text = $"$ {total}";
        }
    }
}
