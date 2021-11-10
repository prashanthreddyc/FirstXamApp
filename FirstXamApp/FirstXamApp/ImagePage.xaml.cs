using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        private bool _isWorking;

        public bool IsWorking
        {
            get { return _isWorking; }
            set 
            {
                _isWorking = value; 
                OnPropertyChanged();
            }
        }

        public ImagePage()
        {
            InitializeComponent();

            BindingContext = this;

            LocalImage.Source = new UriImageSource() { Uri = new Uri("https://lorempixel.com/720/1280/fashion/3/") };
        }

        private void DisplayMessage(object sender, EventArgs e)
        {
            DisplayAlert("Message", "You have clicked the Image Button.", "OK");
        }


        private async void PerformActivity(object sender, EventArgs e)
        {
            //MyActivityIndicator.IsVisible = true;
            //MyActivityIndicator.IsRunning = true;

            IsWorking = true;

            await Task.Delay(5000);

            IsWorking = false;

            //MyActivityIndicator.IsVisible = false;
            //MyActivityIndicator.IsRunning = false;

            DisplayAlert("Message", "You have clicked the Image Button.", "OK");
        }
    }
}