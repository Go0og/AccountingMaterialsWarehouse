using Contract.BindingModel;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class User : IUser
    {
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public int Id { get; set; }

        public static User? Create(UserBindingModel Model)
        {
            return Model != null ? new User
            {
                Login = Model.Login,
                Password = Model.Password,
            } : null;
        }
   
    }
}
