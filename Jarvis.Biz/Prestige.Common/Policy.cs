using System;
namespace Prestige.Common
{
    public class Policy
    {
        private static Policy _instance;

        private Policy()
        {
        }

        public static Policy Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new Policy();
                }
                return _instance;
            }
        }
    }
}
