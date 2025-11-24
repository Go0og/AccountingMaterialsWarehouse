using Contract.BindingModel;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class MOL : IMOL
    {
        public string Name { get; set; } = string.Empty;

        public int Id { get; set; }

        public static MOL? Create(MOLBindingModel Model)
        {
            return Model != null ? new MOL
            {
                Name = Model.Name,
            } : null;
        }

        public void Update(MOLBindingModel Model)
        {
            if (Model == null ) return;

            Model.Name = Name;
        }
    }
}
