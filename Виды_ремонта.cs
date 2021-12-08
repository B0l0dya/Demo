namespace System_Machine_Tools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Виды ремонта")]
    public partial class Виды_ремонта
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Виды_ремонта()
        {
            Заказы = new HashSet<Заказы>();
        }

        [Key]
        [Column("Вид ремонта")]
        [StringLength(50)]
        public string Вид_ремонта { get; set; }

        [Column(TypeName = "money")]
        public decimal Стоимость { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы { get; set; }
    }
}
