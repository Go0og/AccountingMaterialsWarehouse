using DataModel.Enum;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.PresenterModel
{
    public class OperationPresenterModel  
    {
        public TypeOperation TypeOperation;
        public DateTime DateTime;
        public List<int> Quantity = new List<int>();
        public float Summa;
        public List<int> MaterialId = new List<int>();
        public int DivisionId;
        public int SupplierId;
        public int WareHouseId;

        public int Id;
    }
}
