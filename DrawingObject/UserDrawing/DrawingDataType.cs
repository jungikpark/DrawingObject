using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingObject.UserDrawing
{
    public enum ShapeType
    {
        Shape_Rect,
        Shape_Ellipse,
        Shape_Image
    }

    public enum ShapeRegionEdit
    {
        Mode_None,
        Mode_Size_Lft,
        Mode_Size_Rgt,
        Mode_Size_Top,
        Mode_Size_Btm,
        Mode_Move
    }
}
