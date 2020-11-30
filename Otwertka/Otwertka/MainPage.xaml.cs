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
            aboutlist.ItemsSource = GetMenuList();
            var homepage = typeof(View.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Minust",
                Detail = "Lühike info",
                ImagePath = "info.png",
                TargetPage = typeof(View.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu kogemus",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "notepad.png",
                TargetPage = typeof(View.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu oskused",
                Detail = "Natuke rohkem minu oskustest",
                ImagePath = "skills.png",
                TargetPage = typeof(View.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu võidud",
                Detail = "Ma olen uhke!!!",
                ImagePath = "nagradi.jpg",
                TargetPage = typeof(View.ExperiencePage)
            });
            return list;
        }
        private void aboutlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedMenuItems = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = SelectedMenuItems.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}

