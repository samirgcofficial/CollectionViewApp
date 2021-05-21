using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CollectionViewApp.Model;
using CollectionViewApp.View;
using Xamarin.Forms;

namespace CollectionViewApp.ViewModel
{
    public class MyHomePageViewModel : BindableObject
    {

        private ObservableCollection<MyHomeModel> myHomeModels;
        public ObservableCollection<MyHomeModel> MyHomeModels
        {
            get => myHomeModels;
            set
            {
                if (value == myHomeModels) return;
                myHomeModels = value;
                OnPropertyChanged();
            }
        }
        public MyHomeModel SelectedItem { get; set; }

        INavigation Navigation => Application.Current.MainPage.Navigation;


        public ICommand ItemSelectedCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (SelectedItem == null)
                        return;

                    if(SelectedItem.Identifier ==1)
                    {
                       await Navigation.PushAsync(new MyPageA());
                    }
                    else if(SelectedItem.Identifier == 2)
                    {

                       await Navigation.PushAsync(new MyPageB());
                    }
                    SelectedItem = null;
                });
            }
        }

        public MyHomePageViewModel()
        {
            MyHomeModels = new ObservableCollection<MyHomeModel>
            {
                new MyHomeModel{Identifier= 1, PropertyName ="Go To Page 1"},
                new MyHomeModel{Identifier= 2, PropertyName ="Go To Page 2"},
            };
        }
    }
}
