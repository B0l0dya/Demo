namespace System_Machine_Tools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Авторизация
    {
        [Key]
        [Column("№ Код авторизации")]
        public int C__Код_авторизации { get; set; }

        [Column("Электронная почта")]
        [Required]
        [StringLength(50)]
        public string Электронная_почта { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        [Column("Код доступа")]
        [Required]
        [StringLength(1)]
        public string Код_доступа { get; set; }
    }
}
