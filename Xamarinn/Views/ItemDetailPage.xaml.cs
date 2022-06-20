using System.ComponentModel;
using Xamarin.Forms;
using Xamarinn.ViewModels;

namespace Xamarinn.Views
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