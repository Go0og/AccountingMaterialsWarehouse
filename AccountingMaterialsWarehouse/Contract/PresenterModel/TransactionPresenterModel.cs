using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.PresenterModel
{
    public class TransactionPresenterModel 
    {
        public DateTime DateTime;
        public int OperationId;
        public int Subconto1_DT;
        public int Subconto1_KT;
        public int Subconto2_DT;
        public int Subconto2_KT;
        public int Subconto3_DT;
        public int Subconto3_KT;
        public int Quantity;
        public float Summa;
        public int AccountKT;
        public int AccountDT;

        public int Id;
    }
}
