namespace PingPongPlayersAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public int PlayerID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        [Required]
        [StringLength(20)]
        public string SkillLevel { get; set; }

        [Required]
        [StringLength(40)]
        public string Email { get; set; }
    }
}
