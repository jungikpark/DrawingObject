using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingObject.UserDrawing;

namespace DrawingObject
{
    public partial class MainForm : Form
    {
        public userObject userObj = null;
        public int StagX_Idx = -1;
        public int StagY1_Idx = -1;
        public int StagY2_Idx = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjectsSetting objSettingDlg = new ObjectsSetting();
            objSettingDlg.ShowDialog();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (userObj == null)
            {
                userObj = new userObject();
                userObj.Set_DrawingPanel(pnlDrawing);
            }

            if (txtShapeCnt.Text.Length <= 0) return;
            if (txtLoadFilePath.Text.Length <= 0) return;
            userObj.Load_ShapeFile_To_Object(txtLoadFilePath.Text, Convert.ToInt32(txtShapeCnt.Text));
        }

        private bool Parse_Shapes_Info(string strStageIdx, ref int[] shapesIdx)
        {
            if (strStageIdx.Length <= 0) return false;

            //--
            string[] strIndex = strStageIdx.Split(',');
            shapesIdx = new int[strIndex.Length];
            for (int i = 0; i < strIndex.Length; i++)
            {
                if (int.TryParse(strIndex[i], out shapesIdx[i]) == false) return false;
            }

            return true;
        }
        private void btnRegAnimate_Click(object sender, EventArgs e)
        {
            int[] shapesIdx = null;
            if (Parse_Shapes_Info(txtStgY1Idx.Text, ref shapesIdx) == true)
            {
                txtStgY1Idx.Enabled = false;
                userObj.Reg_Shapes_Animate(out StagY1_Idx, shapesIdx);
            }

            if (Parse_Shapes_Info(txtStgY2Idx.Text, ref shapesIdx) == true)
            {
                txtStgY2Idx.Enabled = false;
                userObj.Reg_Shapes_Animate(out StagY2_Idx, shapesIdx);
            }

            if (Parse_Shapes_Info(txtStgXIdx.Text, ref shapesIdx) == true)
            {
                txtStgXIdx.Enabled = false;
                userObj.Reg_Shapes_Animate(out StagX_Idx, shapesIdx);
            }
        }

        private void btnMovStgY1_Click(object sender, EventArgs e)
        {
            int OffY = 0;
            if (StagY1_Idx < 0) return;
            if (int.TryParse(txtMovStgY1.Text, out OffY) == false) return;

            if (OffY != 0)
                txtMovStgY1.Text = "0";
            else
                txtMovStgY1.Text = "-200";

            userObj.Move_Shapes_Animate(StagY1_Idx, 0, OffY);
        }

        private void btnMovStgY2_Click(object sender, EventArgs e)
        {
            int OffY = 0;
            if (StagY2_Idx < 0) return;
            if (int.TryParse(txtMovStgY2.Text, out OffY) == false) return;

            if (OffY != 0)
                txtMovStgY2.Text = "0";
            else
                txtMovStgY2.Text = "-200";

            userObj.Move_Shapes_Animate(StagY2_Idx, 0, OffY);
        }

        private void btnMovStgX_Click(object sender, EventArgs e)
        {
            int OffX = 0;
            if (StagX_Idx < 0) return;
            if (int.TryParse(txtMovStgX.Text, out OffX) == false) return;

            if (OffX != 0)
                txtMovStgX.Text = "0";
            else
                txtMovStgX.Text = "160";

            userObj.Move_Shapes_Animate(StagX_Idx, OffX, 0);
        }
    }
}
