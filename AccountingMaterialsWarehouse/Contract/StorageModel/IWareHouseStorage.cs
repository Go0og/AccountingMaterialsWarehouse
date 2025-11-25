using Contract.BindingModel;
using Contract.SearchModel;
using Contract.StorageModel.dbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel
{
    public interface IWareHouseStorage
    {
        public List<WareHouse> GetFullList();
        public List<WareHouse> GetFillteredList(WareHouseSearchModel Model);
        public WareHouse? GetItem(WareHouseSearchModel Model);

        public bool CreateWareHouse(WareHouseBindingModel model);
        public bool UpdateWareHouse(WareHouseBindingModel Model);
        public bool DeleteWareHouse(WareHouseBindingModel Model);
    }
}
