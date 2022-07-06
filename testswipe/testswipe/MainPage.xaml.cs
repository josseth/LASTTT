using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testswipe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            await DisplayAlert("INFO", "AGREGADO A FAVORITOS", "OK");
        }

        private async void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            await DisplayAlert("INFO", "ELIMINADO", "OK");
            swipe1.IsVisible = false;
        }
    }
}
