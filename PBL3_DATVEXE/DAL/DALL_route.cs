using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_DATVEXE.DTO;
using System.Data;
using System.Data.SqlClient;

namespace PBL3_DATVEXE.DAL
{
    class DALL_route
    {
        private static DALL_route _Instance;
        public static DALL_route Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DALL_route();
                return _Instance;
            }
            private set { }

        }
        private DALL_route()
        {
        }

        public List<DTO_route> getallroute()
        {

            List<DTO_route> data = new List<DTO_route>();
            string q = "select * from Route";
            foreach (DataRow i in DB_H.Instance.get(q).Rows)
            {
                data.Add(getroute(i));
            }
            return data;
        }

        public DTO_route getroute(DataRow dr)
        {

            return new DTO_route
            {
                id_route = dr["id_route"].ToString(),
                departure = dr["departure"].ToString(),
                arrival = dr["arrival"].ToString(),
                deleted = Convert.ToBoolean(dr["deleted"].ToString())



            };

        }



        public void addroute_DAL(DTO_route r)
        {
            string query = "insert into Route values ('";
            query += r.id_route + "', '" + r.departure + "', '" + r.arrival + "', '"
                + false + "');";
            DB_H.Instance.Ex(query);

        }
        public void updateRoutebyid_route(DTO_route s)
        {
            string querry = "update Route set id_route = '" + s.id_route + "', departure = '" + s.departure
                + "', arrival = '" + s.arrival + "', deleted = '" + false
                + "' where id_route = '" + s.id_route + "'";
            DB_H.Instance.Ex(querry);
        }




        public void deleteRoute_DALL(DTO_route s)
        {
            string querry = "update Route set id_route = '" + s.id_route + "', departure = '" + s.departure
                + "', arrival = '" + s.arrival + "', deleted = '" + true
                + "' where id_route = '" + s.id_route + "'";
            DB_H.Instance.Ex(querry);
        }
    }
}
