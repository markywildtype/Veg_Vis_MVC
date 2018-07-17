using System;
using VegVisMVC.Models;
namespace VegVisMVC.Data
{
    public class LondonRepository
    {
        private static Entry[] _entries = {

        };

        public Entry[] GetEntries()
        {
            return _entries;
        }
    }
}
