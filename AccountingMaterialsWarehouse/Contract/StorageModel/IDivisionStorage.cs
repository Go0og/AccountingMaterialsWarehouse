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
    public interface IDivisionStorage
    {
        public List<Division> GetFullList();
        public List<Division> GetFillteredList(DivisionSearchModel Model);
        public Division? GetItem(DivisionSearchModel Model);

        public bool CreateDivision(DivisionbindingModel model);
        public bool UpdateDivision(DivisionbindingModel Model);
        public bool DeleteDivision(DivisionbindingModel Model);
    }
}
