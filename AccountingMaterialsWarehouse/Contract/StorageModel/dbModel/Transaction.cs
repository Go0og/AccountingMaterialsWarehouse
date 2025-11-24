using Contract.BindingModel;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.StorageModel.dbModel
{
    public class Transaction : ITransaction
    {
        public DateTime DateTime { get; set; }
        public int OperationId { get; set; }
        public int Subconto1_DT { get; set; }
        public int Subconto1_KT { get; set; }
        public int Subconto2_DT { get; set; }
        public int Subconto2_KT { get; set; }
        public int Subconto3_DT { get; set; }
        public int Subconto3_KT { get; set; }
        public int Quantity { get; set; }
        public float Summa { get; set; }
        public int AccountKT { get; set; }
        public int AccountDT { get; set; }

        public int Id {get; set; }

        public static Transaction? Create(TransactionBindingModel Model)
        {
            return Model != null ? new Transaction
            {
                DateTime = Model.DateTime,
                OperationId = Model.OperationId,
                Subconto1_DT = Model.Subconto1_DT,
                Subconto1_KT = Model.Subconto1_KT,
                Subconto2_DT = Model.Subconto2_DT,
                Subconto2_KT = Model.Subconto2_KT,
                Subconto3_DT = Model.Subconto3_DT,
                Quantity = Model.Quantity,
                Summa = Model.Summa,
                AccountKT = Model.AccountKT,
                AccountDT = Model.AccountDT,
                   
            } : null;
        }

        public void Update(TransactionBindingModel Model)
        {
            if (Model == null) return;

            DateTime = Model.DateTime;
            OperationId = Model.OperationId;
            Subconto1_DT = Model.Subconto1_DT;
            Subconto1_KT = Model.Subconto1_KT;
            Subconto2_DT= Model.Subconto2_DT;
            Subconto2_KT= Model.Subconto2_KT;
            Subconto3_DT= Model.Subconto3_DT;
            Subconto3_KT = Model.Subconto3_KT;
            Quantity = Model.Quantity;
            Summa = Model.Summa;
            AccountKT = Model.AccountKT;
            AccountDT = Model.AccountDT;
        }
    }
}
