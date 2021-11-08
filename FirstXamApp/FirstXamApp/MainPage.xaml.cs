using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstXamApp
{
	public partial class MainPage : ContentPage
	{
		private int _times = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			MySecondLabel.Text = MyEntry.Text;
		}

		private void GridExampleButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new GridExample());
		}
	}
}
