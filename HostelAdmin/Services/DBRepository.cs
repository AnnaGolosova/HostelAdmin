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

        public static Заселение GetOccupancy(int index)
        {
            return db.Заселение.Where(i => i.Код == index).First();
        }

        internal static List<Жильцы> GetLivers()
        {
            return db.Жильцы.Where(i => i.Код != 0).ToList();
        }

        internal static List<Комнаты> GetRooms()
        {
            return db.Комнаты.Where(i => i.Код != 0).ToList();
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
            return db.OccupancyFull.ToList();
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

        public static void ChangeOccupy(Заселение i)
        {
            Заселение item = db.Заселение.Where(ii => ii.Код == i.Код).First();
            item.ДатаЗаселения = i.ДатаЗаселения;
            item.ДатаВыселения = i.ДатаВыселения;
            item.КодЖильца = i.КодЖильца;
            item.КодКомнаты = i.КодКомнаты;
            db.SaveChanges();
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
                item.Дежурства .Count!= 0))
                return DeleteState.HasReferences;
            db.DeleteRoom(index);
            return DeleteState.Success;
        }
    }
}
