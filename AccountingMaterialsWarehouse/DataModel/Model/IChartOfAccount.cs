using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Model
{
     public interface IChartOfAccount : Iid
     {
          int NumberAccount { get; set; } 
          string NameAccount {  get; set; }
          int NumberSubaccount { get; set; }
          string NameSubaccount { get; set; }
     }
}
