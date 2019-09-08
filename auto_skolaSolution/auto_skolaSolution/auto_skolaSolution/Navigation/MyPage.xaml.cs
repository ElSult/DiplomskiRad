using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace auto_skolaSolution.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage : MasterDetailPage
    {
        public MyPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MyPageMenuItem;
            if (item == null)
                return;

            if(item.TargetType == typeof(Login))
            {
                Global.prijavljeniKandidat = null;
                Application.Current.MainPage = new Login();
                return;
            }

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}