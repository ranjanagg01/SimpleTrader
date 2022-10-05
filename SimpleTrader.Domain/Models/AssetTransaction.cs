using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Models
{
    public class AssetTransaction
    {
        public int Id { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
    }
}
