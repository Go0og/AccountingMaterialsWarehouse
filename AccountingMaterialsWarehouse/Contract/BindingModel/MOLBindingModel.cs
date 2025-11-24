using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.BindingModel
{
    public class MOLBindingModel : IMOL
    {
        public string Name { get ; set ; } = string.Empty;

        public int Id { get; set; }
    }
}
