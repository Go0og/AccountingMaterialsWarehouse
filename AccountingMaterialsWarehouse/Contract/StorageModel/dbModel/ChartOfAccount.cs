using Contract.BindingModel;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class ChartOfAccount : IChartOfAccount
    {
        public int NumberAccount { get; set; }
        public string NameAccount { get; set; } = string.Empty;
        public int NumberSubaccount { get; set; }
        public string NameSubaccount { get; set; } = string.Empty;

        public int Id { get; set; }

        public static ChartOfAccount? Create(ChartOfAccountBindingModel Model)
        {
            return Model != null ? new ChartOfAccount { Id = Model.Id, 
                                                        NameAccount = Model.NameAccount,
                                                        NameSubaccount = Model.NameSubaccount,
                                                        NumberAccount = Model.NumberAccount,
                                                        NumberSubaccount = Model.NumberSubaccount,
                                                        } : null;

        }
        public void Update(ChartOfAccountBindingModel Model)
        {
            if(Model == null) return;

            NameAccount = Model.NameAccount;
            NameSubaccount = Model.NameSubaccount;
            NumberAccount = Model.NumberAccount;
            NumberSubaccount = Model.NumberSubaccount;
        }
    }
}
