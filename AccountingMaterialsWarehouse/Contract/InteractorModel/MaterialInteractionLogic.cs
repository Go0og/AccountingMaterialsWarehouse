using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface MaterialInteractionLogic
    {
        public List<MaterialBindingModel> GetFillteredList(MaterialSearchModel searchModel);
        public MaterialBindingModel GetItem(MaterialSearchModel searchModel);

        public bool Create(MaterialBindingModel model);
        public bool Update(MaterialBindingModel model);
        public bool Delete(MaterialBindingModel model);
    }
}
