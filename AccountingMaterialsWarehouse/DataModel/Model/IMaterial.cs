using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Model
{
     public interface IMaterial : BaseItem
     {
        float Price { get; set; }

        int AccountId { get; set; }    
     }
} 
