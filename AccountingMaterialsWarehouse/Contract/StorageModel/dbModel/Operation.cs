using Contract.BindingModel;
using DataModel.Enum;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class Operation : IOperation
    {
        public TypeOperation TypeOperation { get; set; }
        public DateTime DateTime { get; set; }
        public List<int> Quantity { get; set; } = new List<int>();
        public float Summa { get; set; }
        public List<int> MaterialId { get; set; } = new List<int>();
        public int DivisionId { get; set; }
        public int SupplierId { get; set; }
        public int WareHouseId { get; set; }

        public int Id {get; set; }

        public static Operation? Create(OperationBindingModel Model)
        {
            return Model != null ? new Operation
            {
                TypeOperation = Model.TypeOperation,
                DateTime = Model.DateTime,
                Quantity = Model.Quantity,
                Summa = Model.Summa,
                MaterialId = Model.MaterialId,
                WareHouseId = Model.WareHouseId,
            } : null;
        }

        public void Update (OperationBindingModel Model)
        {
            if (Model == null) return;

            TypeOperation = Model.TypeOperation;
            DateTime = Model.DateTime;
            Quantity = Model.Quantity;
            Summa = Model.Summa;
            MaterialId = Model.MaterialId;
            WareHouseId = Model.WareHouseId;
        }
    }
}
