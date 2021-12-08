namespace System_Machine_Tools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказы
    {
        [Key]
        [Column("№ Заказа")]
        public int C__Заказа { get; set; }

        [Column("№ Станка")]
        public int C__Станка { get; set; }

        [Column("Вид ремонта")]
        [Required]
        [StringLength(50)]
        public string Вид_ремонта { get; set; }

        [Column("№ Бригады")]
        public int C__Бригады { get; set; }

        [Column("Дата сдачи")]
        public DateTime Дата_сдачи { get; set; }

        [Column("Дата возврата по плану")]
        public DateTime Дата_возврата_по_плану { get; set; }

        [Column("Дата возврата по факту")]
        public DateTime Дата_возврата_по_факту { get; set; }

        [Column("Статус заказа")]
        [Required]
        [StringLength(1)]
        public string Статус_заказа { get; set; }

        public virtual Бригады Бригады { get; set; }

        public virtual Виды_ремонта Виды_ремонта { get; set; }

        public virtual Станки Станки { get; set; }
    }
}
