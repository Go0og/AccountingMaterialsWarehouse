using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface MOLInteractorLogic
    {
        public List<MOLBindingModel> GetFillteredList(MOLSearchModel searchModel);
        public MOLBindingModel GetItem(MOLSearchModel searchModel);

        public bool Create(MOLBindingModel model);
        public bool Update(MOLBindingModel model);
        public bool Delete(MOLBindingModel model);
    }
}
