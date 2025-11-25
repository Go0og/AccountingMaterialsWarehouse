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
    public interface ISupplierStorage
    {
        public List<Supplier> GetFullList();
        public List<Supplier> GetFillteredList(SupplierSearchModel Model);
        public Supplier? GetItem(SupplierSearchModel Model);

        public bool CreateSupplier(SupplierBindingModel model);
        public bool UpdateSupplier(SupplierBindingModel Model);
        public bool DeleteSupplier(SupplierBindingModel Model);
    }
}
