using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageCurrentPageIssue
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tab : ContentPage
	{
		public Tab ()
		{
			InitializeComponent ();
            _btn.Clicked += _btn_Clicked;
		}

        private async void _btn_Clicked(object sender, EventArgs e)
        {
            var parent = this.Parent as TabbedPage;
            if (parent?.CurrentPage != null)
                await DisplayAlert("CurrentPage", Title, "Close");
        }
    }
}