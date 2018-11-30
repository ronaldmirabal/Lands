namespace Lands.ViewModels
{
    using Models;

    public class LandViewModel : BaseViewModel
    {
        
        public LandViewModel(Land land)
        {
            this.Land = land;
        }

        #region Propiedades
        public Land Land
        {
            get;
            set;
        }
        #endregion

    }
}
