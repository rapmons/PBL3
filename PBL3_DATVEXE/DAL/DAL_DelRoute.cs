using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PBL3_DATVEXE.DTO;

namespace PBL3_DATVEXE.DAL
{
    class DAL_DelRoute
    {
        private static DAL_DelRoute _Instance;
        public static DAL_DelRoute Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_DelRoute();
                return _Instance;
            }
            private set { }

        }
        private DAL_DelRoute()
        {
        }
        public DTO_delRoute_xl getdelroute_xl(DataRow dr)
        {

            return new DTO_delRoute_xl
            {
                id_delroute = dr["id_detroute"].ToString(),
                id_route = dr["id_route"].ToString(),
                id_vehicle = dr["id_vehicle"].ToString(),
                date = Convert.ToDateTime(dr["date"].ToString()),
                time_start = Convert.ToDateTime(dr["time_start"].ToString()),
                price = Convert.ToDouble(dr["price"].ToString()),
                deleted = Convert.ToBoolean(dr["deleted"].ToString())



            };

        }
        public List<DTO_delRoute_xl> getalldelroute_xl()
        {

            List<DTO_delRoute_xl> data = new List<DTO_delRoute_xl>();
            string q = "select * from DetailRoute";
            foreach (DataRow i in DB_H.Instance.get(q).Rows)
            {
                data.Add(getdelroute_xl(i));
            }
            return data;
        }

        public List<DTO_DelRoute> getalldelroute()
        {

            List<DTO_DelRoute> data = new List<DTO_DelRoute>();
            string q = "select * from DetailRoute";
            foreach (DataRow i in DB_H.Instance.get(q).Rows)
            {
                data.Add(getdelroute(i));
            }
            return data;
        }
         public string doiRoute(string id_Route)
        {
            string route = "";
            foreach(DTO_route i in DALL_route.Instance.getallroute())
            {
                if(i.id_route==id_Route)
                {
                    route = (i.departure.ToString() + i.arrival.ToString());
                }
            }
            return route;
        }
        
        public string doiVehicle(string id_Vehicle)
        {
            string vehicle = "";
            return vehicle;
        }
        public DTO_DelRoute getdelroute(DataRow dr)
        {

            return new DTO_DelRoute
            {
                id_delroute = dr["id_detroute"].ToString(),
                route = doiRoute(dr["id_route"].ToString()),
                vehicle = dr["id_vehicle"].ToString(),
                date = Convert.ToDateTime(dr["date"].ToString()),
                time_start = dr["time_start"].ToString(),
                price = Convert.ToDouble(dr["price"].ToString()),
                deleted= Convert.ToBoolean(dr["deleted"].ToString())



            };

        }



        public void adddelroute_DAL(DTO_delRoute_xl r)
        {
            string query = "insert into DetailRoute values ('";
            query += r.id_delroute + "', '" + r.id_route + "', '" + r.id_vehicle + "', '"+r.date+"','"+r.price+"','"+r.time_start+"','"
                + false + "');";
            DB_H.Instance.Ex(query);

        }
        public void updatedelRoutebyid_delroute(DTO_delRoute_xl s)
        {
            string querry = "update DetailRoute set id_detroute = '" + s.id_delroute + "',id_route= '" + s.id_route + "', id_vehicle='" + s.id_vehicle + "', date='" + s.date + "',price='" + s.price + "',time_start='" + s.time_start + "',deleted='"
                + false
                + "' where id_detroute = '" + s.id_delroute + "'";
            DB_H.Instance.Ex(querry);
        }




        public void deletedelRoute_DALL(DTO_delRoute_xl s)
        {
            string querry = "update DetailRoute set id_detroute = '" + s.id_delroute + "',id_route= '" + s.id_route + "', id_vehicle='" + s.id_vehicle + "', date='" + s.date + "',price='" + s.price + "',time_start='" + s.time_start + "',deleted='"
               + true
               + "' where id_detroute = '" + s.id_delroute + "'";
            DB_H.Instance.Ex(querry);
        }
    }
}
