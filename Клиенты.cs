namespace System_Machine_Tools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиенты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Клиенты()
        {
            Станки = new HashSet<Станки>();
        }

        [Key]
        [Column("№ Клиента")]
        public int C__Клиента { get; set; }

        [Column("Название фирмы клиента")]
        [Required]
        [StringLength(50)]
        public string Название_фирмы_клиента { get; set; }

        [Column("Адрес фирмы")]
        [Required]
        [StringLength(80)]
        public string Адрес_фирмы { get; set; }

        [Column("ФИО контактного лица")]
        [Required]
        [StringLength(50)]
        public string ФИО_контактного_лица { get; set; }

        [Required]
        [StringLength(11)]
        public string Телефон { get; set; }

        [Column("Электронная почта")]
        [Required]
        [StringLength(30)]
        public string Электронная_почта { get; set; }

        [Column("Имя файла с фото")]
        [StringLength(50)]
        public string Имя_файла_с_фото { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Станки> Станки { get; set; }
    }
}
