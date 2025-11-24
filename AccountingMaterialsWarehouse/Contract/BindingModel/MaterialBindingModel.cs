using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.BindingModel
{
    public class MaterialBindingModel : IMaterial
    {
        public float Price { get ; set ; }
        public int AccountId { get ; set ; }
        public string Name { get ; set ; } = string.Empty;

        public int Id { get; set; }
    }
}
