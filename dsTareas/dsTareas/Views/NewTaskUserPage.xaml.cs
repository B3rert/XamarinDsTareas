using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FilePicker;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dsTareas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTaskUserPage : ContentPage
    {
        public NewTaskUserPage()
        {
            InitializeComponent();
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
              //  lbl.Text = file.FileName;
            }
        }
    }
}