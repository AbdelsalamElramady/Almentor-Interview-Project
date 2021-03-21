using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlmentorInterviewProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookListViewPage : ContentPage
    {
        private BooksService _bookService;

        public ObservableCollection<string> Items { get; set; }

        public BookListViewPage()
        {
            _bookService = new BooksService();

            InitializeComponent();

            List<Book> books = _bookService.GetBooks(Constants.BooksEndpoint);
            MyListView.ItemsSource = books;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var book = e.Item as Book;

            await DisplayAlert($"Book Name: { book.Name }", $"Price: { book.Price }$", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
