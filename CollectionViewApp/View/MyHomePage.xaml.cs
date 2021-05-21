using System;
using System.Collections.Generic;
using CollectionViewApp.ViewModel;
using Xamarin.Forms;

namespace CollectionViewApp.View
{
    public partial class MyHomePage : ContentPage
    {
        public MyHomePage()
        {
            InitializeComponent();
            BindingContext = new MyHomePageViewModel();
        }
    }
}
