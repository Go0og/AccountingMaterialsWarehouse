using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface DivisionInteractorLogic
    {
        public List<DivisionbindingModel> GetFillteredList(DivisionSearchModel searchModel);
        public DivisionbindingModel GetItem(DivisionSearchModel searchModel);

        public bool Create(DivisionbindingModel model);
        public bool Update(DivisionbindingModel model);
        public bool Delete(DivisionbindingModel model);
    }
}
