﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HostelEntities : DbContext
    {
        public HostelEntities()
            : base("name=HostelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ВыдачаИнвентаря> ВыдачаИнвентаря { get; set; }
        public virtual DbSet<Дежурства> Дежурства { get; set; }
        public virtual DbSet<Должности> Должности { get; set; }
        public virtual DbSet<Жильцы> Жильцы { get; set; }
        public virtual DbSet<Заселение> Заселение { get; set; }
        public virtual DbSet<Инвентарь> Инвентарь { get; set; }
        public virtual DbSet<Комнаты> Комнаты { get; set; }
        public virtual DbSet<Нарушения> Нарушения { get; set; }
        public virtual DbSet<Оплата> Оплата { get; set; }
        public virtual DbSet<Посещения> Посещения { get; set; }
        public virtual DbSet<РемонтКомнат> РемонтКомнат { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<ВыданныйИнвентарь> ВыданныйИнвентарь { get; set; }
        public virtual DbSet<ЗаселениеРасширенная> ЗаселениеРасширенная { get; set; }
        public virtual DbSet<OccupancyFull> OccupancyFull { get; set; }
    
        [DbFunction("HostelEntities", "ДежурстваПоПараметрам")]
        public virtual IQueryable<ДежурстваПоПараметрам_Result> ДежурстваПоПараметрам(Nullable<int> кодКомнаты)
        {
            var кодКомнатыParameter = кодКомнаты.HasValue ?
                new ObjectParameter("КодКомнаты", кодКомнаты) :
                new ObjectParameter("КодКомнаты", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ДежурстваПоПараметрам_Result>("[HostelEntities].[ДежурстваПоПараметрам](@КодКомнаты)", кодКомнатыParameter);
        }
    
        [DbFunction("HostelEntities", "ЗаселениеДляЖильца")]
        public virtual IQueryable<ЗаселениеДляЖильца_Result> ЗаселениеДляЖильца(Nullable<int> кодЖильца)
        {
            var кодЖильцаParameter = кодЖильца.HasValue ?
                new ObjectParameter("КодЖильца", кодЖильца) :
                new ObjectParameter("КодЖильца", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ЗаселениеДляЖильца_Result>("[HostelEntities].[ЗаселениеДляЖильца](@КодЖильца)", кодЖильцаParameter);
        }
    
        public virtual ObjectResult<ЗаселениеПоПараметрам_Result> ЗаселениеПоПараметрам(Nullable<int> номерКомнаты, Nullable<int> количествоИнвертаряНаСкладе)
        {
            var номерКомнатыParameter = номерКомнаты.HasValue ?
                new ObjectParameter("НомерКомнаты", номерКомнаты) :
                new ObjectParameter("НомерКомнаты", typeof(int));
    
            var количествоИнвертаряНаСкладеParameter = количествоИнвертаряНаСкладе.HasValue ?
                new ObjectParameter("КоличествоИнвертаряНаСкладе", количествоИнвертаряНаСкладе) :
                new ObjectParameter("КоличествоИнвертаряНаСкладе", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ЗаселениеПоПараметрам_Result>("ЗаселениеПоПараметрам", номерКомнатыParameter, количествоИнвертаряНаСкладеParameter);
        }
    
        public virtual ObjectResult<ИнвентарьДляЖильца_Result> ИнвентарьДляЖильца(Nullable<int> кодЖильца)
        {
            var кодЖильцаParameter = кодЖильца.HasValue ?
                new ObjectParameter("КодЖильца", кодЖильца) :
                new ObjectParameter("КодЖильца", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ИнвентарьДляЖильца_Result>("ИнвентарьДляЖильца", кодЖильцаParameter);
        }
    
        public virtual int НомерПоследнейОплаты(Nullable<int> p)
        {
            var pParameter = p.HasValue ?
                new ObjectParameter("P", p) :
                new ObjectParameter("P", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("НомерПоследнейОплаты", pParameter);
        }
    
        public virtual int ОплатаПоПараметрам(Nullable<int> кодЗаселения)
        {
            var кодЗаселенияParameter = кодЗаселения.HasValue ?
                new ObjectParameter("КодЗаселения", кодЗаселения) :
                new ObjectParameter("КодЗаселения", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ОплатаПоПараметрам", кодЗаселенияParameter);
        }
    
        public virtual int ПолучитьНарушения(Nullable<int> кодЗаселения)
        {
            var кодЗаселенияParameter = кодЗаселения.HasValue ?
                new ObjectParameter("КодЗаселения", кодЗаселения) :
                new ObjectParameter("КодЗаселения", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ПолучитьНарушения", кодЗаселенияParameter);
        }
    
        public virtual int ПосещенияПоПараметрам(Nullable<int> кодЗаселения)
        {
            var кодЗаселенияParameter = кодЗаселения.HasValue ?
                new ObjectParameter("КодЗаселения", кодЗаселения) :
                new ObjectParameter("КодЗаселения", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ПосещенияПоПараметрам", кодЗаселенияParameter);
        }
    
        public virtual int DeleteOccupancy(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteOccupancy", idParameter);
        }
    }
}