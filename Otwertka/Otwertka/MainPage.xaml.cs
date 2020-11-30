using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Otwertka
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            ProfileImage.Source = ImageSource.FromFile("Profil.jpg");
            aboutlist.ItemSource = GetMenuList();
            var homepage = typeof(Views.AboutPage);
            Detail = new NavigationPage(new News());
            IsPresented = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
            public List<MasterMenuItems> GetMenuList()
        {
            Detail = new NavigationPage(new Comrads());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new News());
        }

        private void aboutlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
