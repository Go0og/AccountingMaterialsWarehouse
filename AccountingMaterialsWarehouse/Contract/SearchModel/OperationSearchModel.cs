using DataModel.Enum;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.SearchModel
{
    public class OperationSearchModel  
    {
        public TypeOperation? TypeOperation;
        public DateTime? DateTime;
        public List<int>? Quantity;
        public float? Summa;
        public List<int>? MaterialId;
        public int? DivisionId;
        public int? SupplierId;
        public int? WareHouseIdSend;
        public int? WareHouseIdRecipient;

        public int? Id;
    }
}
