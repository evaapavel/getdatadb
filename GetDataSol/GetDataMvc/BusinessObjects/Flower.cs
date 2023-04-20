using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetDataMvc.BusinessObjects
{

    [Table("F_FLOWER")]
    public class Flower
    {

        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("SPECIES")]
        public string Species { get; set; }

        [Column("PREVAILING_COLOR")]
        public Color PrevailingColor { get; set; }



        public Flower()
        {
        }



        public Flower(int id, string species, Color prevailingColor)
        {
            this.ID = id;
            this.Species = species;
            this.PrevailingColor = prevailingColor;
        }


    }
}
