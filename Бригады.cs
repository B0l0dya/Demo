namespace System_Machine_Tools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Бригады
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Бригады()
        {
            Заказы = new HashSet<Заказы>();
        }

        [Key]
        [Column("№ Бригады")]
        public int C__Бригады { get; set; }

        [Column("ФИО бригадира")]
        [Required]
        [StringLength(50)]
        public string ФИО_бригадира { get; set; }

        [Column("Фото бригадира")]
        [StringLength(50)]
        public string Фото_бригадира { get; set; }

        [Column("Описание функций бригады")]
        [StringLength(150)]
        public string Описание_функций_бригады { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы { get; set; }
    }
}
