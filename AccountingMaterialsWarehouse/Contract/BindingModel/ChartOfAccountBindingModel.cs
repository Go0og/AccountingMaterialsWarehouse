using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.BindingModel
{
    public class ChartOfAccountBindingModel : IChartOfAccount
    {
        public int NumberAccount { get; set; }
        public string NameAccount { get; set; } = string.Empty;
        public int NumberSubaccount { get; set; }
        public string NameSubaccount { get ; set ; } = string.Empty;

        public int Id { get; set; }
    }
}
