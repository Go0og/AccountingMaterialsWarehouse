using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface TransactionInteractorLogic
    {
        public List<TransactionBindingModel> GetFillteredList(TransactionSearchModel searchModel);
        public TransactionBindingModel GetItem(TransactionSearchModel searchModel);

        public bool Create(TransactionBindingModel model);
        public bool Update(TransactionBindingModel model);
        public bool Delete(TransactionBindingModel model);
    }
}
