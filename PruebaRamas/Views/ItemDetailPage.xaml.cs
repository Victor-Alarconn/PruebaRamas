using PruebaRamas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PruebaRamas.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}