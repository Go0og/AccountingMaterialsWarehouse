using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface WareHouseInteractorLogic
    {
        public List<WareHouseBindingModel> GetFillteredList(WareHouseSearchModel searchModel);
        public WareHouseBindingModel GetItem(WareHouseSearchModel searchModel);

        public bool Create(WareHouseBindingModel model);
        public bool Update(WareHouseBindingModel model);
        public bool Delete(WareHouseBindingModel model);
    }
}
