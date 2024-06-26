﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DrawingObject.UserDrawing
{
    [Serializable]
    public class objShapeData
    {
        public int LineThick;
        public int LineColor;
        public bool bFill;
        public int FillColor;
        public ShapeType shapeType;
        public int shapeRegion_X;
        public int shapeRegion_Y;
        public int shapeRegion_Width;
        public int shapeRegion_Height;
        public int shapeOrgRegion_X;
        public int shapeOrgRegion_Y;
        public int shapeOrgRegion_Width;
        public int shapeOrgRegion_Height;
        public int ptMargin;
        public string imageFile = string.Empty;
    }

    class objShape
    {
        private int LineThick;
        private Color LineColor;
        private bool bFill;
        private Color FillColor;
        private ShapeType shapeType;
        private Rectangle shapeRegion;
        private Rectangle shapeOrgRegion;
        private Pen drwPen = null;
        private Brush drwBrush = null;
        private int ptMargin = 2;
        private string imageFile = string.Empty;
        private Bitmap shapeImg = null;

        public objShape()
        {
            drwPen = new Pen(Color.Black, 1);
            drwBrush = new SolidBrush(Color.Black);
        }
        public objShape(objShapeData shapeData)
        {
            if(shapeData.shapeType == ShapeType.Shape_Image)
            {
                this.imageFile = shapeData.imageFile;
                shapeType = ShapeType.Shape_Image;
                shapeImg = new Bitmap(this.imageFile);

                shapeRegion = new Rectangle(shapeData.shapeRegion_X, shapeData.shapeRegion_Y,
                    shapeData.shapeRegion_Width, shapeData.shapeRegion_Height);
                shapeOrgRegion = new Rectangle(shapeData.shapeOrgRegion_X, shapeData.shapeOrgRegion_Y,
                    shapeData.shapeOrgRegion_Width, shapeData.shapeOrgRegion_Height);
            }
            else
            {
                this.LineThick = shapeData.LineThick;
                this.LineColor = Color.FromArgb(shapeData.LineColor);
                this.bFill = shapeData.bFill;
                this.FillColor = Color.FromArgb(shapeData.FillColor);
                this.shapeType = shapeData.shapeType;
                this.drwPen = new Pen(this.LineColor, shapeData.LineThick);
                this.drwBrush = new SolidBrush(this.FillColor);

                shapeRegion = new Rectangle(shapeData.shapeRegion_X, shapeData.shapeRegion_Y,
                    shapeData.shapeRegion_Width, shapeData.shapeRegion_Height);
                shapeOrgRegion = new Rectangle(shapeData.shapeOrgRegion_X, shapeData.shapeOrgRegion_Y,
                    shapeData.shapeOrgRegion_Width, shapeData.shapeOrgRegion_Height);
            }
        }
        public objShape(int posX, int posY, string imageFile)
        {
            this.imageFile = imageFile;
            shapeType = ShapeType.Shape_Image;
            shapeImg = new Bitmap(this.imageFile);
            shapeRegion = new Rectangle(posX, posY, shapeImg.Width, shapeImg.Height);
        }
        public objShape(ShapeType shapeType, Rectangle shapeRegion, int LineThick, Color LineColor, bool bFill, Color FillColor)
        {
            this.LineThick = LineThick;
            this.LineColor = LineColor;
            this.bFill = bFill;
            this.FillColor = FillColor;
            this.shapeType = shapeType;
            this.shapeRegion = shapeRegion;
            this.shapeOrgRegion = shapeRegion;
            this.drwPen = new Pen(LineColor, LineThick);
            this.drwBrush = new SolidBrush(FillColor);
        }
        public void CopyToObjShapeData(ref objShapeData shapeData)
        {
            shapeData.LineThick = LineThick;
            shapeData.LineColor = Convert.ToInt32(LineColor.ToArgb());
            shapeData.bFill = bFill;
            shapeData.FillColor = Convert.ToInt32(FillColor.ToArgb());
            shapeData.shapeType = shapeType;
            shapeData.shapeRegion_X = shapeRegion.X;
            shapeData.shapeRegion_Y = shapeRegion.Y;
            shapeData.shapeRegion_Width = shapeRegion.Width;
            shapeData.shapeRegion_Height = shapeRegion.Height;
            shapeData.shapeOrgRegion_X = shapeOrgRegion.X;
            shapeData.shapeOrgRegion_Y = shapeOrgRegion.Y;
            shapeData.shapeOrgRegion_Width = shapeOrgRegion.Width;
            shapeData.shapeOrgRegion_Height = shapeOrgRegion.Height;

            shapeData.ptMargin = ptMargin;
            shapeData.imageFile = imageFile;
        }
        public Color ShapeColor
        {
            set
            {
                FillColor = value;
                drwBrush.Dispose();
                drwBrush = new SolidBrush(FillColor);
            }
        }
        public bool IsPtInRect(int ptX, int ptY)
        {
            int stX = shapeRegion.X;
            int edX = shapeRegion.X + shapeRegion.Width;
            int stY = shapeRegion.Y;
            int edY = shapeRegion.Y + shapeRegion.Height;

            if (ptX >= stX && ptX <= edX)
                if (ptY >= stY && ptY <= edY)
                    return true;

            return false;
        }
        public bool IsPtOnLftLine(int ptX, int ptY)
        {
            return IsPointOnX(ptX, ptY, shapeRegion.X, ptMargin, shapeRegion.Y, shapeRegion.Y + shapeRegion.Height);
        }
        public bool IsPtOnTopLine(int ptX, int ptY)
        {
            return IsPointOnY(ptX, ptY, shapeRegion.X, shapeRegion.X + shapeRegion.Width, shapeRegion.Y, ptMargin);
        }
        public bool IsPtOnRgtLine(int ptX, int ptY)
        {
            return IsPointOnX(ptX, ptY, shapeRegion.X + shapeRegion.Width, ptMargin, shapeRegion.Y, shapeRegion.Y + shapeRegion.Height);
        }
        public bool IsPtOnBtmLine(int ptX, int ptY)
        {
            return IsPointOnY(ptX, ptY, shapeRegion.X, shapeRegion.X + shapeRegion.Width, shapeRegion.Y + shapeRegion.Height, ptMargin);
        }
        public bool FillRegion => bFill;
        public ShapeType Shape => shapeType;
        public Rectangle ShapeRegion
        {
            get { return shapeRegion; }
            set { shapeRegion = value; }
        }
        public Rectangle ShapeOrgRegion
        {
            get { return shapeOrgRegion; }
            set { shapeOrgRegion = value; }
        }
        public void DrawShape(Graphics gp)
        {
            switch (shapeType)
            {
                case ShapeType.Shape_Rect:
                    DrawRect(gp, bFill);
                    break;

                case ShapeType.Shape_Ellipse:
                    DrawEllipse(gp, bFill);
                    break;

                case ShapeType.Shape_Image:
                    DrawImage(gp);
                    break;
            }
        }

        private bool IsPointOnX(int ptX, int ptY, int X, int MarginX, int stY, int edY)
        {
            int stX = X - MarginX;
            int edX = X + MarginX;

            if (ptX >= stX && ptX <= edX)
                if (ptY >= stY && ptY <= edY)
                    return true;

            return false;
        }
        private bool IsPointOnY(int ptX, int ptY, int stX, int edX, int Y, int MarginY)
        {
            int stY = Y - MarginY;
            int edY = Y + MarginY;

            if (ptX >= stX && ptX <= edX)
                if (ptY >= stY && ptY <= edY)
                    return true;

            return false;
        }
        private void DrawRect(Graphics gp, bool bFillRect)
        {
            if (bFillRect)
                gp.FillRectangle(drwBrush, shapeRegion.X, shapeRegion.Y, shapeRegion.Width, shapeRegion.Height);
            else
                gp.DrawRectangle(drwPen, shapeRegion.X, shapeRegion.Y, shapeRegion.Width, shapeRegion.Height);
        }
        private void DrawEllipse(Graphics gp, bool bFillEllipse)
        {
            if (bFillEllipse)
                gp.FillEllipse(drwBrush, shapeRegion.X, shapeRegion.Y, shapeRegion.Width, shapeRegion.Height);
            else
                gp.DrawEllipse(drwPen, shapeRegion.X, shapeRegion.Y, shapeRegion.Width, shapeRegion.Height);
        }
        private void DrawImage(Graphics gp)
        {
            if (shapeImg == null) return;

            //--
            gp.DrawImage(shapeImg, shapeRegion);
        }
    }

    //-- Animate Class
    class animateObject
    {
        private userObject parentsObj = null;
        private int[] animateIndex = null;
        private bool bMoving = false;
        private int posIncrement = 2;
        private int SignX = 1;
        private int SignY = 1;
        private int LastPosX = 0;
        private int LastPosY = 0;
        private int tarOff_X = 0;
        private int tarOff_Y = 0;

        public animateObject(userObject parentsObj)
        {
            this.parentsObj = parentsObj;
        }
        public void Reg_Animate_Shapes(int[] shapesIdx, int posIncrement)
        {
            if (posIncrement <= 0) posIncrement = 2;

            //-- Set Animate Shapes
            this.posIncrement = posIncrement;
            this.animateIndex = new int[shapesIdx.Length];
            for (int i = 0; i < shapesIdx.Length; i++)
            {
                this.animateIndex[i] = shapesIdx[i];
            }
        }
        public void Move_Shapes_Animate(int Off_X, int Off_Y)
        {
            SignX = 1;
            SignY = 1;
            tarOff_X = Off_X;
            tarOff_Y = Off_Y;

            if (LastPosX > tarOff_X) SignX = -1;
            if (LastPosY > tarOff_Y) SignY = -1;
            
            //--
            if (bMoving == false)
            {
                Thread aniThread = new Thread(ShapesMovingThread);
                aniThread.Start();
            }
        }

        private void ShapesMovingThread()
        {
            //--
            bMoving = true;
            
            while (true)
            {
                //--
                if (LastPosX == tarOff_X && LastPosY == tarOff_Y) break;

                //--
                LastPosX += (posIncrement * SignX);
                LastPosY += (posIncrement * SignY);

                //--
                if (SignX > 0)
                {
                    if (LastPosX >= tarOff_X) LastPosX = tarOff_X;
                }
                else
                {
                    if (LastPosX <= tarOff_X) LastPosX = tarOff_X;
                }

                //--
                if (SignY > 0)
                {
                    if (LastPosY >= tarOff_Y) LastPosY = tarOff_Y;
                }
                else
                {
                    if (LastPosY <= tarOff_Y) LastPosY = tarOff_Y;
                }

                parentsObj.Move_Shapes(animateIndex, LastPosX, LastPosY);
                Thread.Sleep(15);//약 60frame
            }
            
            //--
            bMoving = false;
        }
    }

    /*
     * Object는 하나 또는 하나 이상의 Shape으로 구성된다.
     * Object 전체를 움직일 수도 원하는 Shape만 움직일 수도 있다.(이동시 원위치 기준 Offset으로 이동한다)
     * Shape은 Index로 관리 한다.(추가된 순서)
     * Edit Mode가 따로 있다
     */
    public class userObject
    {
        private bool bLButtonDn = false;
        private Point DownPoint = new Point();
        private bool bEditMode = false;
        private int EditShapeIdx = -1;
        private string strEditRegion = string.Empty;
        private Rectangle oldDrwRegion = new Rectangle();
        private Rectangle EditRegion = new Rectangle();
        private ShapeRegionEdit EditMode = ShapeRegionEdit.Mode_None;
        private Panel drwCanvas = null;
        private Graphics gp = null;
        private List<objShape> shapeList = new List<objShape>();
        private List<animateObject> animateList = new List<animateObject>();



        //-- double buffer
        private object objDrwLock = new object();
        private Bitmap Buffer = null;
        private Graphics buffGp = null;

        public void Save_ShapeListToFile(string shapeListPath)
        {
            for (int i = 0; i < shapeList.Count; i++)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(objShapeData));
                objShapeData shapeData = new objShapeData();
                shapeList[i].CopyToObjShapeData(ref shapeData);
                System.IO.TextWriter writer = new StreamWriter(shapeListPath + "\\ShapeData_" + i.ToString() + ".xml");
                serializer.Serialize(writer, shapeData);
                writer.Close();
            }
        }
        public void Load_ShapeFile_To_Object(string shapeListPath, int shapeCnt)
        {
            for (int i = 0; i < shapeCnt; i++)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(objShapeData));
                System.IO.TextReader reader = new StreamReader(shapeListPath + "\\ShapeData_" + i.ToString() + ".xml");

                objShapeData shapeData = serializer.Deserialize(reader) as objShapeData;
                objShape shape = new objShape(shapeData);
                shapeList.Add(shape);

                reader.Close();
            }

            Draw_Object(true);
        }

        public void Set_DrawingPanel(Panel drwCanvas)
        {
            this.drwCanvas = drwCanvas;
            gp = drwCanvas.CreateGraphics();

            //-- double buffer
            if (Buffer != null) Buffer.Dispose();
            Buffer = new Bitmap(drwCanvas.Size.Width, drwCanvas.Size.Height);
            buffGp = Graphics.FromImage(Buffer);

            //-- Event
            drwCanvas.Paint += Object_Paint;
            drwCanvas.MouseMove += Canvas_Mouse_Move;
            drwCanvas.MouseDown += Canvas_Mouse_Down;
            drwCanvas.MouseUp += Canvas_Mouse_Up;
        }
        public bool Edit_Mode
        {
            set
            {
                bEditMode = value;
            }
            get
            {
                return bEditMode;
            }
        }
        public int Shape_Count => shapeList.Count;

        public void Add_Image_Shape(int posX, int posY, string imageFile)
        {
            objShape shape = new objShape(posX, posY, imageFile);
            shapeList.Add(shape);
        }
        public void Add_Shape(ShapeType shapeType, Rectangle shapeRegion, int LineThick, Color LineColor, bool bFill, Color FillColor)
        {
            objShape shape = new objShape(shapeType, shapeRegion, LineThick, LineColor, bFill, FillColor);
            shapeList.Add(shape);
        }
        public void Delete_LastShape()
        {
            Delete_Shape(shapeList.Count - 1);
        }
        public void Delete_Shape(int shapeIdx)
        {
            if (shapeIdx < 0) return;
            if (shapeIdx >= shapeList.Count) return;

            shapeList.RemoveAt(shapeIdx);
            Draw_Object(true);
        }
        public void Set_Shape_Color(int shapeIdx, Color shapeColor)
        {
            if (shapeIdx < 0) return;
            if (shapeIdx >= shapeList.Count) return;

            shapeList[shapeIdx].ShapeColor = shapeColor;
            Draw_Object(true);
        }
        public int ShapeCount => shapeList.Count;

        public void Move_Shape(int shapeIdx, int offX, int offY)
        {
            if (shapeIdx < 0) return;
            if (shapeIdx >= shapeList.Count) return;

            Rectangle shapeRegion = new Rectangle();
            shapeRegion.X = shapeList[shapeIdx].ShapeOrgRegion.X + offX;
            shapeRegion.Y = shapeList[shapeIdx].ShapeOrgRegion.Y + offY;
            shapeRegion.Width = shapeList[shapeIdx].ShapeOrgRegion.Width;
            shapeRegion.Height = shapeList[shapeIdx].ShapeOrgRegion.Height;
            shapeList[shapeIdx].ShapeRegion = shapeRegion;

            //-- Draw
            Draw_Object(true);
        }
        public void Move_Shapes(int[] shapesIdx, int offX, int offY)
        {
            if (shapesIdx == null) return;
            if (shapesIdx.Length <= 0) return;

            Rectangle shapeRegion = new Rectangle();
            for (int i=0; i< shapesIdx.Length; i++)
            {
                int idx = shapesIdx[i];
                shapeRegion.X = shapeList[idx].ShapeOrgRegion.X + offX;
                shapeRegion.Y = shapeList[idx].ShapeOrgRegion.Y + offY;
                shapeRegion.Width = shapeList[idx].ShapeOrgRegion.Width;
                shapeRegion.Height = shapeList[idx].ShapeOrgRegion.Height;
                shapeList[idx].ShapeRegion = shapeRegion;
            }

            //-- Draw
            Draw_Object(true);
        }
        public void Move_Shape_Org_Pos(int shapeIdx)
        {
            if (shapeIdx < 0) return;
            if (shapeIdx >= shapeList.Count) return;

            shapeList[shapeIdx].ShapeRegion = shapeList[shapeIdx].ShapeOrgRegion;
            Draw_Object(true);
        }
        public void Move_Shapes_Org_Pos(int[] shapesIdx)
        {
            if (shapesIdx == null) return;
            if (shapesIdx.Length <= 0) return;

            for (int i = 0; i < shapesIdx.Length; i++)
            {
                int idx = shapesIdx[i];
                shapeList[idx].ShapeRegion = shapeList[idx].ShapeOrgRegion;
            }

            Draw_Object(true);
        }
        public void MoveShape_EditMode(int shapeIdx, int offX, int offY)
        {
            if (shapeIdx < 0) return;
            if (shapeIdx >= shapeList.Count) return;

            Rectangle editRegion = new Rectangle();
            editRegion = shapeList[shapeIdx].ShapeRegion;
            editRegion.X += offX;
            editRegion.Y += offY;

            //--
            Draw_MoveRect(shapeList[shapeIdx].ShapeRegion, editRegion, Color.Black);
            shapeList[shapeIdx].ShapeRegion = editRegion;
            shapeList[shapeIdx].ShapeOrgRegion = editRegion;
            Draw_Object(true);
        }

        public void Move_Object(int offX, int offY)
        {
            //-- 모든 Shape에 Offset 적용
            Rectangle shapeRegion = new Rectangle();
            foreach (var shape in shapeList)
            {
                //--
                shapeRegion.X = shape.ShapeOrgRegion.X + offX;
                shapeRegion.Y = shape.ShapeOrgRegion.Y + offY;
                shapeRegion.Width = shape.ShapeOrgRegion.Width;
                shapeRegion.Height = shape.ShapeOrgRegion.Height;

                shape.ShapeRegion = shapeRegion;
            }

            //-- Draw
            Draw_Object(true);
        }
        public void Move_Object_Org_Pos()
        {
            foreach (var shape in shapeList)
            {
                shape.ShapeRegion = shape.ShapeOrgRegion;
            }

            //-- Draw
            Draw_Object(true);
        }
        public void Draw_Object(bool bClear = false)
        {
            //--
            if (drwCanvas == null) return;

            lock (objDrwLock)
            {
                //--
                if (bClear) buffGp.Clear(drwCanvas.BackColor);

                //--
                foreach (var shape in shapeList)
                {
                    shape.DrawShape(buffGp);
                }

                gp.DrawImage(Buffer, 0, 0);
            }
        }
        public void Reg_Shapes_Animate(out int aniIdx, int[] shapesIdx, int posIncrement = 5)
        {
            //--
            animateObject aniObj = new animateObject(this);
            aniObj.Reg_Animate_Shapes(shapesIdx, posIncrement);
            animateList.Add(aniObj);
            aniIdx = animateList.Count - 1;
        }
        public void Move_Shapes_Animate(int aniIdx, int Off_X, int Off_Y)
        {
            if (aniIdx < 0) return;
            if (aniIdx >= animateList.Count) return;

            animateList[aniIdx].Move_Shapes_Animate(Off_X, Off_Y);
        }


        private void Draw_MoveRect(Rectangle oldRegion, Rectangle newRegion, Color lineColor)
        {
            //--
            buffGp.Clear(drwCanvas.BackColor);

            //-- 새로운 위치 그리기
            Pen drwPen = new Pen(lineColor, 1);
            buffGp.DrawRectangle(drwPen, newRegion.X, newRegion.Y, newRegion.Width, newRegion.Height);

            //--
            strEditRegion = string.Format("X: {0}, Y: {1}, W: {2}, H: {3}", newRegion.X, newRegion.Y, newRegion.Width, newRegion.Height);
            buffGp.DrawString(strEditRegion, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 10, 10);

            //--
            gp.DrawImage(Buffer, 0, 0);
        }
        private void Object_Paint(object sender, PaintEventArgs e)
        {
            Draw_Object();
        }
        private bool CheckMode()
        {
            if (drwCanvas != null && bEditMode == true) return true;

            Init_EditMode();
            return false;
        }
        private void Init_EditMode()
        {
            oldDrwRegion.X = 0;
            oldDrwRegion.Y = 0;
            oldDrwRegion.Width = 0;
            oldDrwRegion.Height = 0;
            
            bLButtonDn = false;
            EditShapeIdx = -1;
            EditMode = ShapeRegionEdit.Mode_None;
        }
        private void Canvas_Mouse_Move(object sender, MouseEventArgs e)
        {
            if (CheckMode() == false) return;

            //-- Edit Mode
            if (bLButtonDn == true && EditMode != ShapeRegionEdit.Mode_None)
            {
                //--Move
                if(EditMode == ShapeRegionEdit.Mode_Move)
                {
                    int offX = e.X - DownPoint.X;
                    int offY = e.Y - DownPoint.Y;

                    oldDrwRegion = EditRegion;
                    EditRegion.X = shapeList[EditShapeIdx].ShapeRegion.X + offX;
                    EditRegion.Y = shapeList[EditShapeIdx].ShapeRegion.Y + offY;
                    
                    //--
                    Draw_MoveRect(oldDrwRegion, EditRegion, Color.Black);
                }
                //-- Left
                else if (EditMode == ShapeRegionEdit.Mode_Size_Lft)
                {
                    int offX = e.X - DownPoint.X;
                    if (shapeList[EditShapeIdx].ShapeRegion.Width - offX > 0)
                    {
                        oldDrwRegion = EditRegion;
                        EditRegion.X = shapeList[EditShapeIdx].ShapeRegion.X + offX;
                        EditRegion.Width = shapeList[EditShapeIdx].ShapeRegion.Width - offX;
                        Draw_MoveRect(oldDrwRegion, EditRegion, Color.Black);
                    }
                }
                //-- Right
                else if (EditMode == ShapeRegionEdit.Mode_Size_Rgt)
                {
                    int offX = e.X - DownPoint.X;
                    if (shapeList[EditShapeIdx].ShapeRegion.Width + offX > 0)
                    {
                        oldDrwRegion = EditRegion;
                        EditRegion.X = shapeList[EditShapeIdx].ShapeRegion.X;
                        EditRegion.Width = shapeList[EditShapeIdx].ShapeRegion.Width + offX;
                        Draw_MoveRect(oldDrwRegion, EditRegion, Color.Black);
                    }
                }
                //-- Top
                else if (EditMode == ShapeRegionEdit.Mode_Size_Top)
                {
                    int offY = e.Y - DownPoint.Y;
                    if (shapeList[EditShapeIdx].ShapeRegion.Height - offY > 0)
                    {
                        oldDrwRegion = EditRegion;
                        EditRegion.Y = shapeList[EditShapeIdx].ShapeRegion.Y + offY;
                        EditRegion.Height = shapeList[EditShapeIdx].ShapeRegion.Height - offY;
                        Draw_MoveRect(oldDrwRegion, EditRegion, Color.Black);
                    }
                }
                //-- Bottom
                else if (EditMode == ShapeRegionEdit.Mode_Size_Btm)
                {
                    int offY = e.Y - DownPoint.Y;
                    if (shapeList[EditShapeIdx].ShapeRegion.Height + offY > 0)
                    {
                        oldDrwRegion = EditRegion;
                        EditRegion.Y = shapeList[EditShapeIdx].ShapeRegion.Y;
                        EditRegion.Height = shapeList[EditShapeIdx].ShapeRegion.Height + offY;
                        Draw_MoveRect(oldDrwRegion, EditRegion, Color.Black);
                    }
                }

                //-- 지원진 부분 다시 그림
                Draw_Object();
            }
            else
            {
                //-- 마지막 추가한 Shape먼저
                for (int i = shapeList.Count - 1; i >= 0; i--)
                {
                    //-- Shape 경계선인지 체크
                    if (shapeList[i].IsPtOnLftLine(e.X, e.Y))
                    {
                        EditShapeIdx = i;
                        drwCanvas.Cursor = Cursors.SizeWE;
                        EditMode = ShapeRegionEdit.Mode_Size_Lft;
                        return;
                    }
                    if (shapeList[i].IsPtOnRgtLine(e.X, e.Y))
                    {
                        EditShapeIdx = i;
                        drwCanvas.Cursor = Cursors.SizeWE;
                        EditMode = ShapeRegionEdit.Mode_Size_Rgt;
                        return;
                    }
                    if (shapeList[i].IsPtOnTopLine(e.X, e.Y))
                    {
                        EditShapeIdx = i;
                        drwCanvas.Cursor = Cursors.SizeNS;
                        EditMode = ShapeRegionEdit.Mode_Size_Top;
                        return;
                    }
                    if (shapeList[i].IsPtOnBtmLine(e.X, e.Y))
                    {
                        EditShapeIdx = i;
                        drwCanvas.Cursor = Cursors.SizeNS;
                        EditMode = ShapeRegionEdit.Mode_Size_Btm;
                        return;
                    }

                    //-- Shape 안에 있는지 체크
                    if (shapeList[i].IsPtInRect(e.X, e.Y))
                    {
                        EditShapeIdx = i;
                        drwCanvas.Cursor = Cursors.SizeAll;
                        EditMode = ShapeRegionEdit.Mode_Move;
                        return;
                    }
                }

                //-- Set default
                if (drwCanvas.Cursor != Cursors.Default)
                {
                    drwCanvas.Cursor = Cursors.Default;
                    EditShapeIdx = -1;
                    EditMode = ShapeRegionEdit.Mode_None;
                }
            }
        }
        private void Canvas_Mouse_Down(object sender, MouseEventArgs e)
        {
            if (CheckMode() == false) return;
            if (EditShapeIdx < 0) return;
            if (EditMode == ShapeRegionEdit.Mode_None) return;

            if (e.Button == MouseButtons.Left)
            {
                bLButtonDn = true;
                DownPoint.X = e.X;
                DownPoint.Y = e.Y;
                EditRegion = shapeList[EditShapeIdx].ShapeRegion;
            }
        }
        private void Canvas_Mouse_Up(object sender, MouseEventArgs e)
        {
            if (bLButtonDn == true && EditMode != ShapeRegionEdit.Mode_None)
            {
                //--
                shapeList[EditShapeIdx].ShapeRegion = EditRegion;
                shapeList[EditShapeIdx].ShapeOrgRegion = EditRegion;

                //--
                Init_EditMode();
                Draw_Object(true);
            }
        }
    }
}