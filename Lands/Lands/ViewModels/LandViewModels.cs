

namespace Lands.ViewModels
{
    using Models;

    public class LandViewModels
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
