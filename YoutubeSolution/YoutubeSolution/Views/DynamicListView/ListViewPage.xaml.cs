using System;
using System.Collections.Generic;

using Xamarin.Forms;
using YoutubeSolution.ViewModels;

namespace YoutubeSolution.Views.DynamicListView
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = new PersonViewModels();
        }

    }
}
