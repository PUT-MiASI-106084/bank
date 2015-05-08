namespace TheBank.Lib
{
    public abstract class SmartCard
    {
        private bool? _isActive;
        public string Id { get; set; }

        public bool IsActive
        {
            get { return _isActive ?? false; }
            set
            {
                if (_isActive == null)
                {
                    _isActive = value;
                }
                else
                {
                    if (value == false)
                    {
                        _isActive = false;
                    }
                }
            }
        }
    }
}