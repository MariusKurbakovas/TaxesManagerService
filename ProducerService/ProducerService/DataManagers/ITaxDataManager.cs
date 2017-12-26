using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerService.DataManagers
{
    public interface ITaxDataManager
    {
        decimal GetTax(string municipality, DateTime date);
    }
}
