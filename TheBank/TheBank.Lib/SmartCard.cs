using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib
{
    public abstract class SmartCard
    {
        private string _Id;
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private bool? _IsActive;
        public bool IsActive
        {
            get { return _IsActive??false; }
            set {
                if (_IsActive == null)
                {
                    _IsActive = value;
                }
                else {
                    if (value == false) {
                        _IsActive = value;
                    }
                }
            }
        }
        
        
    }
}
