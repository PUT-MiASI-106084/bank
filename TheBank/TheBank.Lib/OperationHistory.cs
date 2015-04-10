using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib
{
    public class OperationHistory
    {
        private List<OperationHistory> _ListOfOperationHistory;

        public IEnumerable<OperationHistory> GetListOfOperationHistory()
        {
            return _ListOfOperationHistory;
        }
    }
}
