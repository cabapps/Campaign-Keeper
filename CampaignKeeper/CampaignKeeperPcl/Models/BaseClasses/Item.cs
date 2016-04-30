using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl
{
    public abstract class Item
    {
        [Required]
        public int Id { get; set; }
    }
}
