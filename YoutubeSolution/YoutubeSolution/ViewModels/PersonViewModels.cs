using System;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using YoutubeSolution.Models;

namespace YoutubeSolution.ViewModels
{
    public class PersonViewModels : BaseViewModel
    {
        #region Attributes
        public string name;
        public string age;
        public bool isRefreshing = false;
        public object listViewSource;
        #endregion

        #region Properties
        public string NameTxt
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }

        public string AgeTxt
        {
            get { return this.age; }
            set { SetValue(ref this.age, value); }
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }

        public object ListViewSource {

            get { return this.listViewSource; }
            set {
                SetValue(ref this.listViewSource, value);
            }
        }
        #endregion

        #region Commands
        public ICommand InsertCommand
        {
            get
            {
                return new RelayCommand(InsertMethod);
            }
        }
        #endregion

        #region Methods
        private async void InsertMethod()
        {
         
            var person = new PersonModel
            {
                NameField = name,
                AgeField = age,
            };

            await App.Database.SavePersonModelAsync(person);

            this.IsRefreshing = true;

            await Task.Delay(1000);

            LoadData();

            this.IsRefreshing = false;
        }

        public async Task LoadData()
        {
            this.ListViewSource = await App.Database.GetPersonModel();
        }

        #endregion


        #region Constructor
        public PersonViewModels()
        {
            LoadData();
        }
        #endregion
    }
}
