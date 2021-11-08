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
		public ImagePage()
		{
			InitializeComponent();

			LocalImage.Source = new UriImageSource() { Uri = new Uri("https://lorempixel.com/720/1280/fashion/3/") }; 
		}
	}
}