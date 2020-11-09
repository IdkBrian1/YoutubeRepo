using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeSolution.Database;
using YoutubeSolution.Views.AccessApp;
using YoutubeSolution.Views.DynamicListView;
using YoutubeSolution.Views.MasterDetail;
using YoutubeSolution.Views.Tabbed;

namespace YoutubeSolution
{
    public partial class App : Application
    {

        #region Database
        static DatabaseQuerys database;

        public static DatabaseQuerys Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuerys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBname.db"));
                }
                return database;
            }
        }
        #endregion

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegisterPage());  
            
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
