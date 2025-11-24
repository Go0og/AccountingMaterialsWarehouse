using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.Model;

namespace Contract.BindingModel
{
    public class DivisionbindingModel : IDivision
    {
        public string Name { get ; set ; } = string.Empty;

        public int Id { get; set; }
    }
}
