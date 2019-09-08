using auto_skolaSolution.Rate;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace auto_skolaSolution.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPageMaster : ContentPage
    {
        public ListView ListView=> MenuItemsListView;

        public MyPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyPageMasterViewModel();
           
        }

        class MyPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyPageMenuItem> MenuItems { get; set; }

            public MyPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyPageMenuItem>(new[]
                {
                    new MyPageMenuItem { Id = 0, Title = "Main page", TargetType = typeof(MainPage)},
                    new MyPageMenuItem { Id = 1, Title = "Rezultati testova", TargetType = typeof(Testovi.RezultatiTestova)},
                    new MyPageMenuItem { Id = 2, Title = "RateInstruktor", TargetType = typeof(RateInstruktor) },
                    new MyPageMenuItem { Id = 3, Title = "Pregled termina", TargetType = typeof(Termini.PregledTermina) },
                    new MyPageMenuItem { Id = 4, Title = "Logout", TargetType = typeof(Login) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}