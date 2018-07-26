

namespace lands.ViewModels
{
    using Models;
    public class LandViewModel
    {
        public Land Land
        {
            get;
            set;
        }

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
        } 
        #endregion
    }
}
