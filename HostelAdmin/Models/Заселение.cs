//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заселение
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заселение()
        {
            this.ВыдачаИнвентаря = new HashSet<ВыдачаИнвентаря>();
            this.Нарушения = new HashSet<Нарушения>();
            this.Оплата = new HashSet<Оплата>();
            this.Посещения = new HashSet<Посещения>();
        }
    
        public int Код { get; set; }
        public int КодЖильца { get; set; }
        public int КодКомнаты { get; set; }
        public System.DateTime ДатаЗаселения { get; set; }
        public Nullable<System.DateTime> ДатаВыселения { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ВыдачаИнвентаря> ВыдачаИнвентаря { get; set; }
        public virtual Жильцы Жильцы { get; set; }
        public virtual Комнаты Комнаты { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Нарушения> Нарушения { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Оплата> Оплата { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Посещения> Посещения { get; set; }
    }
}
