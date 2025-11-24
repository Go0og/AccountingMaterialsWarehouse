using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Contract.BindingModel
{
    public class TransactionBindingModel : ITransaction
    {
        public DateTime DateTime { get ; set ; }
        public int OperationId { get ; set ; }
        public int Subconto1_DT { get ; set ; }
        public int Subconto1_KT { get ; set ; }
        public int Subconto2_DT { get ; set ; }
        public int Subconto2_KT { get ; set ; }
        public int Subconto3_DT { get ; set ; }
        public int Subconto3_KT { get ; set ; }
        public int Quantity { get ; set ; }
        public float Summa { get ; set ; }
        public int AccountKT { get ; set ; }
        public int AccountDT { get ; set ; }

        public int Id { get; set; }
    }
}
