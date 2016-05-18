using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Interface
{
    interface IAuditable
    {
         DateTime CreatedDate { get; set; }

         DateTime? LastUpdateDate { get; set; }
    }
}
