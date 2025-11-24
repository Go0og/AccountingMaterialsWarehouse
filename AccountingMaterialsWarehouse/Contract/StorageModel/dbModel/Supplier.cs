using Contract.BindingModel;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class Supplier : ISupplier
    {
        public string Name { get; set; } = string.Empty;

        public int Id {get; set; }

        public static Supplier? Create(SupplierBindingModel Model)
        {
            return Model != null ? new Supplier
            {
                Name = Model.Name,
            } : null;
        }

        public void Update(SupplierBindingModel Model)
        {
            if (Model == null) return;

            Model.Name = Name;
        }
    }
}
