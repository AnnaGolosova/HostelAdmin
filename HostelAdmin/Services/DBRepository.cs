using HostelAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelAdmin.Services
{
    public class DBRepository
    {
        private static HostelEntities _db = null;

        private static HostelEntities db {
            get
            {
                if (_db == null)
                    _db = new HostelEntities();
                _db.Database.Log = s => Debug.WriteLine(s);
                return _db;
            }
            set { _db = value; }
        }

        internal static Сотрудники GetEmployee(int index)
        {
            return db.Сотрудники.Where(i => i.Код == index).First();
        }

        internal static Нарушения GetViolation(int index)
        {
            return db.Нарушения.Find(index);
        }

        internal static List<Должности> GetPositions()
        {
            return db.Должности.Where(i => i.Код != 0).ToList();
        }

        public static Заселение GetOccupancy(int index)
        {
            return db.Заселение.Where(i => i.Код == index).First();
        }

        internal static List<DeliveryFull> GetDeliveryFull()
        {
            return db.DeliveryFull.Where(i => i.Код != 0).ToList();
        }

        internal static List<Инвентарь> GetInventories()
        {
            return db.Инвентарь.Where(i => i.Код != 0).ToList();
        }

        internal static List<Заселение> GetOccupancies()
        {
            return db.Заселение.Where(i => i.Код != 0).ToList();
        }

        internal static List<Жильцы> GetLivers()
        {
            return db.Жильцы.Where(i => i.Код != 0).ToList();
        }

        internal static List<Сотрудники> GetEmployees()
        {
            return db.Сотрудники.Where(i => i.Код != 0).ToList();
        }

        internal static List<Комнаты> GetRooms()
        {
            return db.Комнаты.Where(i => i.Код != 0).ToList();
        }

        internal static void AddEmployee(Сотрудники item)
        {
            db.Сотрудники.Add(item);
            db.SaveChanges();
        }

        public static LoginState Login(string login, string password)
        {
            try
            {
                if (!db.Users.Any(u => u.name.CompareTo(login) == 0))
                    return LoginState.WrongEmail;
                else if (db.Users.Where(u => u.name.CompareTo(login) == 0).First().password.CompareTo(password) == 0)
                    return LoginState.Success;
                else return LoginState.WrongPassword;
            }
            catch(Exception)
            {
                return LoginState.ConnectionError;
            }
        }

        internal static void ChangeOrAddCiolation(Нарушения i)
        {
            if (i.Код == 0)
            {
                db.Нарушения.Add(i);
                db.SaveChanges();
                return;
            }
            Нарушения item = db.Нарушения.Where(ii => ii.Код == i.Код).First();
            item.ДатаОтработки = i.ДатаОтработки;
            item.Отработано = i.Отработано;
            item.СоставНарушения = i.СоставНарушения;
            item.КодЗаселения = i.КодЗаселения;
            db.SaveChanges();
        }

        internal static Комнаты AddRoom(int v1, int v2)
        {
            Комнаты item = new Комнаты();
            item.НомерКомнаты = v1;
            item.Этаж = v2;
            db.Комнаты.Add(item);
            db.SaveChanges();
            return item;
        }

        public static void AddLiver(Жильцы item)
        {
            db.Жильцы.Add(item);
            db.SaveChanges();
        }

        public static List<OccupancyFull> GetОccupancy()
        {
            return db.OccupancyFull.Where(i => i.Код != 0).ToList();
        }

        internal static DeleteState TryDeleteOccupancy(int index, bool forcibly = false)
        {
            try
            {
                if(forcibly)
                {
                    db.DeleteOccupancy(index);

                    return DeleteState.Success;
                }
                if (db.Заселение.Where(o => o.Код == index).First().ВыдачаИнвентаря.Any(v => v.ДатаСдачи == null))
                    return DeleteState.HasInventory;
                else if (db.ВыдачаИнвентаря.Any(i => i.КодЗаселения == index) ||
                         db.Нарушения.Any(i => i.КодЗаселения == index) ||
                         db.Оплата.Any(i => i.КодЗаселения == index))
                    return DeleteState.HasReferences;
                else
                {
                    Заселение item = db.Заселение.Where(o => o.Код == index).First();
                    db.DeleteOccupancy(index);
                    return DeleteState.Success;
                }
            }
            catch(Exception e)
            {
                return DeleteState.ConnectionError;
            }
        }

        internal static void ChangeDelivery(ВыдачаИнвентаря item)
        {
            if(item.Код == 0)
            {
                db.ВыдачаИнвентаря.Add(item);
                db.SaveChanges();
                return;
            }
            ВыдачаИнвентаря newDel = db.ВыдачаИнвентаря.Where(i => i.Код == item.Код).First();
            newDel.ДатаВыдачи = item.ДатаВыдачи;
            newDel.ДатаСдачи = item.ДатаСдачи;
            newDel.КодЗаселения = item.КодЗаселения;
            newDel.КодИнвентаря = item.КодИнвентаря;
            newDel.КодСотрудника = item.КодСотрудника;
            db.SaveChanges();
        }

        public static void ChangeOrAddOccupancy(Заселение i)
        {
            if(i.Код == 0)
            {
                db.Заселение.Add(i);
                db.SaveChanges();
                return;
            }
            Заселение item = db.Заселение.Where(ii => ii.Код == i.Код).First();
            item.ДатаЗаселения = i.ДатаЗаселения;
            item.ДатаВыселения = i.ДатаВыселения;
            item.КодЖильца = i.КодЖильца;
            item.КодКомнаты = i.КодКомнаты;
            db.SaveChanges();
        }

        internal static List<Нарушения> GetViolation()
        {
            return db.Нарушения.ToList();
        }

        internal static Жильцы GetLiver(int index)
        {
            return db.Жильцы.Where(i => i.Код == index).First();
        }

        internal static void ChangeLiver(Жильцы i)
        {
            Жильцы item = db.Жильцы.Where(ii => ii.Код == i.Код).First();
            item.ФИО = i.ФИО;
            item.Адрес = i.Адрес;
            item.Пол = i.Пол;
            db.SaveChanges();
        }

        internal static DeleteState TryDeleteLiver(int index, bool forcibly = false)
        {
            Жильцы item = db.Жильцы.Where(i => i.Код == index).First();
            if(forcibly)
            {
                db.Жильцы.Remove(item);
                db.SaveChanges();
                return DeleteState.Success;
            }
            if (item.Заселение.Count != 0)
                return DeleteState.HasReferences;
            db.Жильцы.Remove(item);
            db.SaveChanges();
            return DeleteState.Success;
        }

        internal static Комнаты AddRoom(Комнаты item)
        {
            db.Комнаты.Add(item);
            db.SaveChanges();
            return item;
        }

        internal static void ChangeRoom(Комнаты item)
        {
            Комнаты newItem = db.Комнаты.Where(i => i.Код == item.Код).First();
            newItem.НомерКомнаты = item.НомерКомнаты;
            newItem.Этаж = item.Этаж;
            db.SaveChanges();
        }

        internal static DeleteState TryDeleteRoom(int index, bool forcibly = false)
        {
            Комнаты item = db.Комнаты.Where(i => i.Код == index).First();
            if (!forcibly && (item.Заселение.Count != 0 ||
                item.Дежурства.Count!= 0))
                return DeleteState.HasReferences;
            db.DeleteRoom(index);
            return DeleteState.Success;
        }

        internal static DeleteState TryDeletePosition(int index, bool forcibly = false)
        {
            Должности item = db.Должности.Where(i => i.Код == index).First();
            if (!forcibly && (db.Сотрудники.Where(s => s.КодДолжности == index).Count() != 0))
                return DeleteState.HasReferences;
            db.DeletePosition(index);
            return DeleteState.Success;
        }

        internal static void AddPosition(Должности item)
        {
            try
            {
                db.Должности.Add(item);
                db.SaveChanges();
            }
            catch(System.Data.Entity.Infrastructure.DbUpdateException)
            {
                throw new System.Data.Entity.Infrastructure.DbUpdateException();
            }
        }

        internal static void ChangePosition(Должности item)
        {
            Должности newItem = db.Должности.Where(i => i.Код == item.Код).First();
            newItem.Название = item.Название;
            db.SaveChanges();
        }

        internal static DeleteState TryDeleteInventory(int index, bool forcibly = false)
        {
            Инвентарь item = db.Инвентарь.Where(i => i.Код == index).First();
            if (!forcibly && (item.ВыдачаИнвентаря.Count != 0 ))
                return DeleteState.HasReferences;
            db.DeleteInventory(index);
            return DeleteState.Success;
        }

        internal static void AddInventory(Инвентарь item)
        {
            db.Инвентарь.Add(item);
            db.SaveChanges();
        }

        internal static void ChangeInventory(Инвентарь item)
        {
            Инвентарь newItem = db.Инвентарь.Where(i => i.Код == item.Код).First();
            newItem.Название = item.Название;
            newItem.Количества = item.Количества;
            db.SaveChanges();
        }

        internal static DeleteState TryDeleteDelivery(int index, bool forcibly = false)
        {
            ВыдачаИнвентаря item = db.ВыдачаИнвентаря.Where(i => i.Код == index).First();
            if (!forcibly && item.ДатаСдачи == null)
                return DeleteState.HasInventory;
            db.ВыдачаИнвентаря.Remove(item);
            db.SaveChanges();
            return DeleteState.Success;
        }

        internal static ВыдачаИнвентаря GetDelivery(int value)
        {
            return db.ВыдачаИнвентаря.Where(i => i.Код == value).First();
        }

        internal static DeleteState TryDeleteEmployee(int index, bool forcibly = false)
        {
            Сотрудники item = db.Сотрудники.Where(i => i.Код == index).First();
            if (!forcibly && item.ВыдачаИнвентаря.Count != 0)
                return DeleteState.HasReferences;
            db.DeleteEmployee(item.Код);
            return DeleteState.Success;
        }

        internal static DeleteState TryDeleteViolation(int index)
        {
            db.DeleteViolation(index);
            return DeleteState.Success;
        }
    }
}
