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
    public interface IOperationStorage
    {
        public List<Operation> GetFullList();
        public List<Operation> GetFillteredList(OperationSearchModel Model);
        public Operation? GetItem(OperationSearchModel Model);

        public bool CreateOperation(OperationBindingModel model);
        public bool UpdateOperation(OperationBindingModel Model);
        public bool DeleteOperation(OperationBindingModel Model);
    }
}
