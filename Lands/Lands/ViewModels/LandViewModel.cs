﻿namespace Lands.ViewModels
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class LandViewModel : BaseViewModel
    {
        #region Atributos
        private ObservableCollection<Border> borders;
        private ObservableCollection<Currency> currencies;
        private ObservableCollection<Language> languages;
        #endregion

        public LandViewModel(Land land)
        {
            this.Land = land;
            this.LoadBordes();
            this.Currencies = new ObservableCollection<Currency>(this.Land.Currencies);
            this.Languages = new ObservableCollection<Language>(this.Land.Languages);
        }

        private void LoadBordes()
        {
            this.Borders = new ObservableCollection<Border>();
            foreach (var border in this.Land.Borders)
            {
                var land = MainViewModel.GetInstance().LandsList
                          .Where(l => l.Alpha3Code == border).FirstOrDefault();
                if (land != null)
                {
                    this.Borders.Add(new Border
                    {
                        Code = land.Alpha3Code,
                        Name = land.Name,
                    });
                }
            }
        }

        #region Propiedades
        public Land Land
        {
            get;
            set;
        }

        public ObservableCollection<Border> Borders
            {
            get { return this.borders; }
            set { this.SetValue(ref this.borders, value); }
            }

        public ObservableCollection<Currency> Currencies
        {
            get { return this.currencies; }
            set { this.SetValue(ref this.currencies, value); }
        }

        public ObservableCollection<Language> Languages
        {
            get { return this.languages; }
            set { this.SetValue(ref this.languages, value); }
        }



        #endregion

    }
}
