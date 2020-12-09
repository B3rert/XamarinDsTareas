using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace dsTareas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();

            Children.Add(new ListPage());
            Children.Add(new NewTaskUserPage());
            //Children.Add(new NewTaskAdminPage());
            Children.Add(new SupportPage());

        }
    }
}