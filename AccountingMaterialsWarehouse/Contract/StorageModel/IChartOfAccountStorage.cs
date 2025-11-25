using Contract.StorageModel.dbModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.BindingModel;

namespace Contract.StorageModel
{
    public interface IChartOfAccountStorage
    {
        public List<ChartOfAccount> GetFullList();
        public List<ChartOfAccount> GetFillteredList(ChartOfAccountSearchModel Model);
        public ChartOfAccount? GetItem(ChartOfAccountSearchModel Model);

        public bool CreateChartOfAccount(ChartOfAccountBindingModel model);
        public bool UpdateChartOfAccount(ChartOfAccountBindingModel Model);
        public bool DeleteChartOfAccount(ChartOfAccountBindingModel Model);
    }
}
