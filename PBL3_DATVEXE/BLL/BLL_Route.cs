using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_DATVEXE.DAL;
using PBL3_DATVEXE.DTO;

namespace PBL3_DATVEXE.BLL
{
    class BLL_Route
    {
        private static BLL_Route _Instance;

        public static BLL_Route Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Route();
                return _Instance;
            }
            private set { }
        }
        private BLL_Route()
        {

        }

        public List<DTO_route> getallRoute()
        {
            return DALL_route.Instance.getallroute();

        }


        public string getmssv()
        {
            string a = "";
            return a;
        }

        public DTO_route Getid_route(string id_route)
        {
            if (id_route == null)
                return null;
            else
            {
                DTO_route s = new DTO_route();
                foreach (DTO_route i in DALL_route.Instance.getallroute())
                {
                    if (i.id_route == id_route)
                    { s = i; }
                }
                return s;
            }
        }
        public void add_route(DTO_route s)
        {
            DALL_route.Instance.addroute_DAL(s);
        }
        public void edit(DTO_route s)
        {
            DALL_route.Instance.updateRoutebyid_route(s);
        }

        public void deleteRoute(string id_route)
        {
            foreach (DTO_route i in DALL_route.Instance.getallroute())
            {
                if (i.id_route == id_route)
                {
                    DALL_route.Instance.deleteRoute_DALL(i);
                }
            }
        }

    }
}
