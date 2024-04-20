using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingObject.UserDrawing
{
    public partial class ObjectsSetting : Form
    {
        bool bFillShape;
        Rectangle shapeRegion;
        ShapeType shapeType;

        //--
        int objIdx = -1;
        int shapeIdx = -1;
        ObjectsManager objMgr = null;
        userObject sel_Object = null;

        //--
        int ObjMoveOffX = 0;
        int ObjMoveOffY = 0;

        public ObjectsSetting()
        {
            InitializeComponent();

            //--
            bFillShape = true;
            shapeType = ShapeType.Shape_Rect;
            Set_Color_Combo_Style();
            objMgr = new ObjectsManager();
        }
        public ObjectsSetting(ObjectsManager objMgr)
        {
            this.objMgr = objMgr;
        }

        private void Set_Color_Combo_Style()
        {
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(
                BindingFlags.Static |
                BindingFlags.DeclaredOnly | BindingFlags.Public
                );

            //--
            int defaultIdx = 0;
            for (int i=0; i< propInfoList.Length; i++)
            {
                this.cbColor.Items.Add(propInfoList[i].Name);
                this.cbLineColor.Items.Add(propInfoList[i].Name);

                //-- 
                if (propInfoList[i].Name.ToUpper() == "BLACK")
                {
                    defaultIdx = i;
                }
            }

            //-- Default Black
            this.cbColor.SelectedIndex = defaultIdx;
            this.cbLineColor.SelectedIndex = defaultIdx;
        }
        private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;

            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 3, rect.Width - 10, rect.Height - 3);
            }
        }

        private void rdoObjectSize_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdoObjectProperty_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFill.Checked == true) bFillShape = true;
            else if (rdoEmpy.Checked == true) bFillShape = false;
        }
        private void rdoObjectType_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoObjRect.Checked == true) shapeType = ShapeType.Shape_Rect;
            else if (rdoObjEllipse.Checked == true) shapeType = ShapeType.Shape_Ellipse;
        }

        private void btnNewObj_Click(object sender, EventArgs e)
        {
            //-- Object하나 생성
            objMgr.Add_New_Object();

            //-- Display Panel 설정
            objMgr.Get_User_Object(objMgr.Objects_Count - 1).Set_DrawingPanel(pnlCanvas);

            //--
            objIdx = objMgr.Objects_Count - 1;
            cbObjList.Items.Add("Obj Idx: " + objMgr.Objects_Count.ToString());
            cbObjList.SelectedIndex = objIdx;
        }
        private void cbObjList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objIdx >= 0)
                objMgr.Get_User_Object(objIdx).Edit_Mode = false;

            objIdx = cbObjList.SelectedIndex;
            objMgr.Get_User_Object(objIdx).Draw_Object();
        }
        private void cbShapeIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            shapeIdx = cbShapeIndex.SelectedIndex;
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            int lineThick, shapeCx, shapeCy;
            if (objIdx < 0) return;
            if (Int32.TryParse(txtLineThick.Text, out lineThick) == false) return;
            if (Int32.TryParse(txtSizeCx.Text, out shapeCx) == false) return;
            if (Int32.TryParse(txtSizeCy.Text, out shapeCy) == false) return;

            //-- Set Region
            shapeRegion.X = 0;
            shapeRegion.Y = 0;
            shapeRegion.Width = shapeCx;
            shapeRegion.Height = shapeCy;

            //--
            Color lineColor = Color.FromName(cbLineColor.Text);
            Color fillColor = Color.FromName(cbColor.Text);
            sel_Object = objMgr.Get_User_Object(objIdx);
            sel_Object.Add_Shape(shapeType, shapeRegion, lineThick, lineColor, bFillShape, fillColor);
            sel_Object.Draw_Object();
            sel_Object.Edit_Mode = true;

            //--
            shapeIdx = sel_Object.ShapeCount - 1;
            cbShapeIndex.Items.Add("Shape Idx: " + sel_Object.ShapeCount.ToString());
            cbShapeIndex.SelectedIndex = shapeIdx;
        }
        private void btnDeleteShape_Click(object sender, EventArgs e)
        {
            if (objIdx < 0) return;
            if (sel_Object.ShapeCount < 0) return;

            objMgr.Get_User_Object(objIdx).Delete_LastShape();
            cbShapeIndex.Items.RemoveAt(sel_Object.ShapeCount - 1);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (objIdx < 0) return;
            objMgr.Get_User_Object(objIdx).Edit_Mode = false;
        }

        private void btnTestObjMove_Click(object sender, EventArgs e)
        {
            if (objIdx < 0) return;
            if (tmrObjMove.Enabled == false)
            {
                ObjMoveOffX = 0;
                ObjMoveOffY = 0;
                tmrObjMove.Enabled = true;
            }
        }
        private void tmrObjMove_Tick(object sender, EventArgs e)
        {
            bool bStop = false;
            if (ObjMoveOffX < 100)
                ObjMoveOffX++;
            else if (ObjMoveOffY < 100)
                ObjMoveOffY++;
            else
                bStop = true;

            objMgr.Get_User_Object(objIdx).Move_Object(ObjMoveOffX, ObjMoveOffY);

            if (bStop) tmrObjMove.Enabled = false;
        }

        private void btnObjOrgPos_Click(object sender, EventArgs e)
        {
            if (objIdx < 0) return;
            objMgr.Get_User_Object(objIdx).Move_Object_Org_Pos();
        }

        private void ShapeJogMove_Click(object sender, EventArgs e)
        {
            if (objIdx < 0) return;
            if (shapeIdx < 0) return;

            int offX = 0, offY = 0;
            if (sender == btnShapeLft) offX = -1;
            else if (sender == btnShapeRgt) offX = 1;
            else if (sender == btnShapeUp) offY = -1;
            else if (sender == btnShapeDown) offY = 1;

            objMgr.Get_User_Object(objIdx).MoveShape_EditMode(shapeIdx, offX, offY);
        }
    }
}
