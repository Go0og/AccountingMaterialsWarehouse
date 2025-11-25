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
    public interface ITransactionStorage
    {
        public List<Transaction> GetFullList();
        public List<Transaction> GetFillteredList(TransactionSearchModel Model);
        public Transaction? GetItem(TransactionSearchModel Model);

        public bool CreateTransaction(TransactionBindingModel model);
        public bool UpdateTransaction(TransactionBindingModel Model);
        public bool DeleteTransaction(TransactionBindingModel Model);
    }
}
