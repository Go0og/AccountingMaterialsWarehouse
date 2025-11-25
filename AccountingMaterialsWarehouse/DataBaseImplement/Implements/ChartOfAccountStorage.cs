using Contract.BindingModel;
using Contract.SearchModel;
using Contract.StorageModel;
using Contract.StorageModel.dbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseImplement.Implements
{
    public class ChartOfAccountStorage : IChartOfAccountStorage
    {
        public bool CreateChartOfAccount(ChartOfAccountBindingModel model)
        {
            using var context = new Database();
            var NewChartOfAccount = ChartOfAccount.Create(model);
            if (NewChartOfAccount == null)
            {
                return false;
            }
            context.ChartOfAccounts.Add(NewChartOfAccount);

            context.SaveChanges();
            return true;
        }
        public bool UpdateChartOfAccount(ChartOfAccountBindingModel Model)
        {
            using var context = new Database();
            var UpdateChartOfAccount = context.ChartOfAccounts.FirstOrDefault(x => x.Id == Model.Id);

            if (UpdateChartOfAccount == null)
            {
                return false;
            }
            UpdateChartOfAccount.Update(Model);
            context.SaveChanges() ;
            return true;
        }

        public bool DeleteChartOfAccount(ChartOfAccountBindingModel Model)
        {
            using var context = new Database();
            var DeleteChartOfAccount = context.ChartOfAccounts.FirstOrDefault(x => x.Id == Model.Id);
            if(DeleteChartOfAccount == null)
            {
                return false;
            }
            context.ChartOfAccounts.Remove(DeleteChartOfAccount);
            context.SaveChanges();
            return true;
        }

        public List<ChartOfAccount> GetFillteredList(ChartOfAccountSearchModel Model)
        {
            using var context = new Database();
            if (Model.Id.HasValue) 
            {
                return context.ChartOfAccounts
                    .Where(x => x.Id == Model.Id)
                    .ToList();
            }
            return new();
        }

        public List<ChartOfAccount> GetFullList()
        {
            using var context = new Database();
            return context.ChartOfAccounts.ToList();
        }

        public ChartOfAccount? GetItem(ChartOfAccountSearchModel Model)
        {
            using var context = new Database();
            if (Model.Id.HasValue)
            {
                return context.ChartOfAccounts.FirstOrDefault(x =>x.Id == Model.Id);
            }
            return null;
        }


    }
}
