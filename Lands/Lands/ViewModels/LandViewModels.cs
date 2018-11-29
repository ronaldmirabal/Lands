

namespace Lands.ViewModels
{
    using Models;

    public class LandViewModels : BaseViewModel
    {
        #region Propiedades
        public Land Land
        {
            get;
            set;
        }
        #endregion



        #region Constructor
        public LandViewModels(Land land)
        {
            this.Land = land;
        }
        #endregion





    }
}
