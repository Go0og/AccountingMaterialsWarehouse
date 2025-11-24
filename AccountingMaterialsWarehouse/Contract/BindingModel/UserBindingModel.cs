using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.BindingModel
{
    public class UserBindingModel : IUser
    {
        public string Login { get; set; } = string.Empty;
        public string Password { get ; set ; } = string.Empty;

        public int Id { get; set; }
    }
}
