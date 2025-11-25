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
    public interface IUserStorage
    {
        public User GetItem(UserSearchModel Model);

        public bool CreateUser(UserBindingModel model);

    }
}
