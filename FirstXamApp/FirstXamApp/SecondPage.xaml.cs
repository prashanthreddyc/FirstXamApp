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
	public partial class SecondPage : ContentPage
	{
		public SecondPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new ThirdPage());
		}

		private void Back_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		private void BackToMain_Clicked(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync();
		}
	}
}