using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Plugin.FilePicker;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dsTareas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SupportPage : ContentPage
    {
        public SupportPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(txtNumeroA.Text);
            }
            catch (Exception ex)
            {
                DisplayAlert("No se puede realizar la llamada", "intentelo luego", "ok");
            }
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(txtNumeroB.Text);
            }
            catch (Exception ex)
            {
                DisplayAlert("No se puede realizar la llamada", "intentelo luego", "ok");
            }
        }
    }
}