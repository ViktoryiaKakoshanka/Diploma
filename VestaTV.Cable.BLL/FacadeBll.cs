using VestaTV.Cable.BLL.Interfaces;
using VestaTV.Cable.BLL.Services;

namespace VestaTV.Cable.BLL
{
    public class FacadeBll : IFacadeBll
    {
        private IMasterServis _masterServis;

        public IMasterServis MasterServis 
        {
            get => _masterServis ?? (_masterServis = new MasterServis());
        }
    }
}
