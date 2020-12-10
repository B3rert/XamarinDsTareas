using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dsTareas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        public SearchBarPage()
        {
            InitializeComponent();
        }

        private void SearchTareasBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}