using Contract.BindingModel;
using Contract.SearchModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.InteractorModel
{
    public interface UserInteractionLogic
    {
        public UserBindingModel GetItem(UserSearchModel searchModel);
    }
}
