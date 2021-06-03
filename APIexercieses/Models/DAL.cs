using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APIexercieses.Models
{
    public class DAL
    {
        public static IDbConnection db;

        /* getall categories
        * get one category
        * insert one category
        * update one category
        * delete one category
        * 
        * getall orderdetails
        * get one order detail
        * insert one order detail
        * update one orderdetail
        * delete one orderdetail
        * 
        * get all shippers
        * get one shipper
        * insert one shipper
        * update one shipper
        * delete one shipper
        */
        //category
        public static List<category> ReadAllCats()
        {
            return db.GetAll<category>().ToList();
        }
        public static category ReadOneCat(int id)
        {
            return db.Get<category>(id);
        }
        public static int CreateCat(category cat)
        {
            db.Insert(cat);
            return cat.categoryId;
        }
        public static int UpdateCat(category cat)
        {
            db.Update(cat);
            return cat.categoryId;
        }
        public static bool DeleteCat(int id)
        {
            category cat = new category();
            cat.categoryId = id;
            db.Delete(cat);
            if(db.Get<category>(id) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //orderdetail
        public static List<orderdetail> ReadAllOD()
        {
            return db.GetAll<orderdetail>().ToList();
        }
        public static orderdetail ReadOneOD(int id)
        {
            return db.Get<orderdetail>(id);
        }
        public static int CreateOD(orderdetail deet)
        {
            db.Insert(deet);
            return deet.orderDetailId;
        }
        public static int UpdateOD(orderdetail deet)
        {
            db.Update(deet);
            return deet.orderDetailId;
        }
        public static bool DeleteOD(int id)
        {
            orderdetail deet = new orderdetail();
            deet.orderDetailId = id;
            db.Delete(deet);
            if (db.Get<orderdetail>(id) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //shipper
        public static List<shipper> ReadAllShipper()
        {
            return db.GetAll<shipper>().ToList();
        }
        public static shipper ReadOneShipper(int id)
        {
            return db.Get<shipper>(id);
        }
        public static int CreateShipper(shipper ship)
        {
            db.Insert(ship);
            return ship.shipperId;
        }
        public static int UpdateShipper(shipper ship)
        {
            db.Update(ship);
            return ship.shipperId;
        }
        public static bool DeleteShipper(int id)
        {
            shipper ship = new shipper();
            ship.shipperId = id;
            db.Delete(ship);
            if (db.Get<shipper>(id) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
