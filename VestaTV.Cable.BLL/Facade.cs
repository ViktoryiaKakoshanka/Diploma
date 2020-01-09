using VestaTV.Cable.BLL.Interfaces;
using VestaTV.Cable.BLL.Services;

namespace VestaTV.Cable.BLL
{
    class Facade : IFacade
    {
        private IMasterServis _masterServis;

        public IMasterServis MasterServis 
        {
            get => _masterServis ?? (_masterServis = new MasterServis());
        }
    }
}
