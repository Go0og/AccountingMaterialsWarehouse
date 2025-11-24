using Contract.BindingModel;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class Division : IDivision
    {
        public string Name { get; set; } = string.Empty;

        public int Id { get; set; }

        public static Division? Create(DivisionbindingModel Model) 
        {
            return Model != null ? new Division
            {
                Id = Model.Id,
                Name = Model.Name,
            } : null;

        }

        public void Update(DivisionbindingModel Model)
        {
            if (Model == null) return;
            Model.Name = Name;
        }
    }
}
