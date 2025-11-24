using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface SupplierInteractorLogic 
    {
        public List<SupplierBindingModel> GetFillteredList(SupplierSearchModel searchModel);
        public SupplierBindingModel GetItem(SupplierSearchModel searchModel);

        public bool Create(SupplierBindingModel model);
        public bool Update(SupplierBindingModel model);
        public bool Delete(SupplierBindingModel model);
    }
}
