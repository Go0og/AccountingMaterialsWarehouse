using DataModel.Enum;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.BindingModel
{
    public class OperationBindingModel : IOperation
    {
        public TypeOperation TypeOperation { get ; set ; }
        public DateTime DateTime { get ; set ; }
        public List<int> Quantity { get ; set ; } = new List<int>();
        public float Summa { get ; set ; }
        public List<int> MaterialId { get ; set ; } = new List<int>();
        public int DivisionId { get ; set ; }
        public int SupplierId { get ; set ; }
        public int WareHouseId { get ; set ; }

        public int Id { get; set; }
    }
}
