using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface ChartOfAccountInteractorLogic
    {
        public List<ChartOfAccountBindingModel> GetFillteredList(ChartOfAccountSearchModel searchModel);
        public ChartOfAccountBindingModel GetItem(ChartOfAccountSearchModel searchModel);

        public bool Create(ChartOfAccountBindingModel model);
        public bool Update(ChartOfAccountBindingModel model);
        public bool Delete(ChartOfAccountBindingModel model);

    }
}
