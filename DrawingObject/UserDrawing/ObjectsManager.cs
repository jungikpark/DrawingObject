using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingObject.UserDrawing
{
    public class ObjectsManager
    {
        private List<userObject> objList = new List<userObject>();

        public void Add_New_Object()
        {
            userObject userObj = new userObject();
            objList.Add(userObj);
        }

        public int Objects_Count => objList.Count;
        public userObject Get_User_Object(int objIdx)
        {
            if (objIdx < 0 || objIdx >= Objects_Count) return null;
            return objList[objIdx];
        }
    }
}
