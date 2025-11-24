using Contract.BindingModel;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class Material : IMaterial
    {
        public float Price { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; } = string.Empty;

        public int Id {get; set; }

        public static Material? Create(MaterialBindingModel Model)
        {
            return Model != null ? new Material
            {
                Name = Model.Name,
                Price = Model.Price,
                AccountId = Model.AccountId,
            } : null;
        }

        public void Update(MaterialBindingModel Model)
        {
            if (Model == null) return;
            Model.Name = Name;
            Model.Price = Price;
            Model.AccountId = AccountId;
        }
    }
}
