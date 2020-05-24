using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Transition
{
	public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			InitializeComponent();
		}
        
        private async void ButtonPage1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void ButtonPage2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void ButtonPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
