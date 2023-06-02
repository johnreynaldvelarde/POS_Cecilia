using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    public class Account_Class
    {
        private string staff_id;
        private Image staff_image;
        private string staff_name;
        private string staff_role;

        public string Staff_ID
        {
            get { return staff_id; }
            set { Staff_ID = value; }
        }

        public Image Staff_Image
        {
            get { return staff_image; }
            set { staff_image = value; }
        }

        public string Staff_Name
        {
            get { return staff_name; }
            set { staff_name = value; }
        }

        public string Staff_Role
        {
            get { return staff_role; }
            set { staff_role = value; }
        }
    }
}
