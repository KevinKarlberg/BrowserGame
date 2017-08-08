using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.DB.Models.Players;

namespace Game.DB.Models.Army
{
    public class Ship
    {
        [Key]
        public Guid ShipId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ShipName { get; set; }
        [Required]
        public int AttackValue { get; set; }
        [Required]
        public int DefenseValue { get; set; }
        public int Armor { get; set; }
        [Required]
        public int Health { get; set; }
        [Required]
        public int GroundTroopCapacity { get; set; }
        [Required]
        public int PeopleToOperate { get; set; }
        [Required]
        public int Speed { get; set; }
        [Required]
        public Guid MarketContentRefId { get; set; }
        public ICollection<Player> Players { get; set; }
        //[ForeignKey("MarketContentRefId")]
        //public virtual Cost Cost { get; set; }
    }
}
