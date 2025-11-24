using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Model
{
    public interface ITransaction : Iid
    {
        DateTime DateTime { get; set; }
        int OperationId { get; set; }

        /// <summary>
        /// Material
        /// </summary>
        int Subconto1_DT { get; set; }
        int Subconto1_KT { get; set; }
        /// <summary>
        /// Supplier
        /// </summary>
        int Subconto2_DT { get; set;}
        int Subconto2_KT { get; set; }
        /// <summary>
        /// Division
        /// </summary>
        int Subconto3_DT { get; set; }
        int Subconto3_KT { get; set; }

        int Quantity { get; set; }
        float Summa { get; set; }
        /// <summary>
        /// Division
        /// </summary>
        int AccountKT { get; set; }
        int AccountDT { get; set; }

    }
}
