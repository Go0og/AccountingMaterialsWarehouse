using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Model
{
    public interface IOperation : Iid
    {

          DateTime DateTime { get; set; }
          List<int> Quantity { get; set; } 
          float Summa { get; set; }

        // External Id model

          List<int> MaterialId { get; set; } 
          int DivisionId { get; set; }
          int SupplierId { get; set; }

        /// <summary>
        /// ИД склада отправителя
        /// </summary>
          int? WareHouseIdSend { get; set; } 
        /// <summary>
        /// ИД склада получателя
        /// </summary>
          int? WareHouseIdRecipient { get; set; }

    }
}
