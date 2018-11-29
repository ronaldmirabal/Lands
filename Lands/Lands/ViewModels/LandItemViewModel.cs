﻿namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    using Models;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LandItemViewModel : Land
    {
        #region Comandos
        public ICommand SelectLandCommand
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }

        private async void SelectLand()
        {
            MainViewModel.GetInstance().Land = new LandViewModels(this);
            await Application.Current.MainPage.Navigation.PushAsync(new LandPage());
        }
        #endregion

    }
}
