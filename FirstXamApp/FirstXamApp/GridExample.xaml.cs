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
	public partial class GridExample : ContentPage
	{
		public GridExample()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new SecondPage());
		}
	}
}