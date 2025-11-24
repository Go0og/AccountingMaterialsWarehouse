using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface OperationInteractionLogic
    {
        public List<OperationBindingModel> GetFillteredList(OperationSearchModel searchModel);
        public OperationBindingModel GetItem(OperationSearchModel searchModel);

        public bool Create(OperationBindingModel model);
        public bool Update(OperationBindingModel model);
        public bool Delete(OperationBindingModel model);
    }
}
