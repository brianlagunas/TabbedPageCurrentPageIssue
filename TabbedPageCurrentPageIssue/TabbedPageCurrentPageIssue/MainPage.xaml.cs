using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPageCurrentPageIssue
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            CurrentPageChanged += MainPage_CurrentPageChanged;
        }

        private async void MainPage_CurrentPageChanged(object sender, EventArgs e)
        {
            if (CurrentPage != null)
                await DisplayAlert("Tab Changed", CurrentPage.Title, "Close");
        }
    }
}
