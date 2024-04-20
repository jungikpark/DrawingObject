using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingObject.UserDrawing
{
    public partial class ObjectsViewer : UserControl
    {
        public ObjectsViewer()
        {
            InitializeComponent();
        }
        public void Set_Parents_Location(ControlCollection parentsCtrl, Point Position)
        {
            //--
            this.Location = Position;
            parentsCtrl.Add(this);
        }
    }
}
