using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class Captain
    {
        private static Captain? _captain = null;
        private static readonly object _lock = new object();

        private Captain()
        {
            Console.WriteLine("You captain has been selected!");
        }

        public static Captain GetCaptain()
        {
            lock (_lock)
            {
                if (_captain == null)
                {
                    _captain = new Captain();
                }
                else
                {
                    Console.WriteLine("You already have a captain!");
                    Console.WriteLine("Send him for the toss.");
                }
                return _captain;
            }
        }
    }
}
