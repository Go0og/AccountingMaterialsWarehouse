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
    public interface IMaterialStorage
    {
        public List<Material> GetFullList();
        public List<Material> GetFillteredList(MaterialSearchModel Model);
        public Material? GetItem(MaterialSearchModel Model);

        public bool CreateMaterial(MaterialBindingModel model);
        public bool UpdateMaterial(MaterialBindingModel Model);
        public bool DeleteMaterial(MaterialBindingModel Model);
    }
}
