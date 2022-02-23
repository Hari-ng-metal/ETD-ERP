using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETD_System
{
    class Item
    {
        public static bool item_status;
        public static int category_id;
        public static int update_prod_id;
        //public static int role_id;

    }

    class User
    {
        public static int user_id { get; set; }
        public static string fname { get; set; }
        public static int role_id { get; set; }

    }

    class Supplier
    {
        public static bool sup_status;
    }

    class Receiving
    {
        public static int supplier_id;
        public static int receiving_last_id;
    }

    class Sales
    {
        public static int customer_id;
        public static int last_id;
    }

    class Printing
    {
        public static string printName { get; set; }
    }
}
