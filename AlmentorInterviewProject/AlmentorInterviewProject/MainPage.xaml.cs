using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlmentorInterviewProject
{
    public partial class MainPage : ContentPage
    {
        private BooksService _bookService;

        public MainPage()
        {
            _bookService = new BooksService();
            InitializeComponent();
            ShowWelcomMessage();
        }

        private void ShowWelcomMessage()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    welcomeMessage.Text = "Hello Android User";
                    break;

                case Device.iOS:
                    welcomeMessage.Text = "Hello iOS User";
                    break;

                default:
                    welcomeMessage.Text = "Hello User";
                    break;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookListViewPage());
        }
    }
}
