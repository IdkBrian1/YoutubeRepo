using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeSolution.Views.MasterDetail;
using YoutubeSolution.Views.Tabbed;

namespace YoutubeSolution
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyMasterDetailPage();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
