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
    
    public partial class OccupancyFull
    {
        public int Код { get; set; }
        public int КодКомнаты { get; set; }
        public string ФИО { get; set; }
        public int НомерКомнаты { get; set; }
        public int Этаж { get; set; }
        public string Адрес { get; set; }
        public string Пол { get; set; }
        public System.DateTime ДатаЗаселения { get; set; }
        public Nullable<System.DateTime> ДатаВыселения { get; set; }
    }
}
