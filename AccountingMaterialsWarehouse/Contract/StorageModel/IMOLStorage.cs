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
    public interface IMOLStorage
    {
        public List<MOL> GetFullList();
        public List<MOL> GetFillteredList(MOLSearchModel Model);
        public MOL? GetItem(MOLSearchModel Model);

        public bool CreateMOL(MOLBindingModel model);
        public bool UpdateMOL(MOLBindingModel Model);
        public bool DeleteMOL(MOLBindingModel Model);
    }
}
