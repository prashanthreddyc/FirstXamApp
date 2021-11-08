using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXamApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ModalPage : ContentPage
	{
		private bool _isEntryChanged = false;

		public ModalPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("My Title", "What ever you were doing is now saved.", "OK");
		}

		private async void Button_Clicked_1(object sender, EventArgs e)
		{
			if (_isEntryChanged)
			{
				var result = await DisplayAlert("Warning", "There are somethings that are changed. Do you want to Save?", "Yes", "No");
				if (result)
				{
					//Save Logic
					Debug.WriteLine("*********************************");
					Debug.WriteLine("Save Logic is Getting Executed...");
					Debug.WriteLine("*********************************");
				}
			}

			Navigation.PopModalAsync();
		}

		private void MyEntry_TextChanged(object sender, TextChangedEventArgs e)
		{
			if(e.NewTextValue != e.OldTextValue)
				_isEntryChanged = true;
			else
				_isEntryChanged = false;
		}

		private async void Button_Clicked_2(object sender, EventArgs e)
		{
			var result = await DisplayPromptAsync("Input", "Enter Age", keyboard: Keyboard.Numeric );

			MyLabel.Text = $"My Age is {result}";
		}

		private async void Button_Clicked_3(object sender, EventArgs e)
		{
			var result = await DisplayActionSheet("Do you want to Delete?", "Cancel", "Delete", "Save", "Go to Home", "Happy Birthday");
			DisplayAlert("Action", result, "OK");
		}
	}
}