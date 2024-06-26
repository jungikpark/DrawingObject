﻿namespace DrawingObject.UserDrawing
{
    partial class ObjectsSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.rdoFixedSize = new System.Windows.Forms.RadioButton();
            this.rdoUserSize = new System.Windows.Forms.RadioButton();
            this.grpObjectSize = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSizeCy = new System.Windows.Forms.TextBox();
            this.txtSizeCx = new System.Windows.Forms.TextBox();
            this.grbObjectTypes = new System.Windows.Forms.GroupBox();
            this.rdoObjEllipse = new System.Windows.Forms.RadioButton();
            this.rdoObjRect = new System.Windows.Forms.RadioButton();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.cbLineColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLineThick = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.rdoEmpy = new System.Windows.Forms.RadioButton();
            this.rdoFill = new System.Windows.Forms.RadioButton();
            this.btnAddShape = new System.Windows.Forms.Button();
            this.btnDeleteShape = new System.Windows.Forms.Button();
            this.btnNewObj = new System.Windows.Forms.Button();
            this.cbObjList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTestObjMove = new System.Windows.Forms.Button();
            this.btnObjOrgPos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbShapeIndex = new System.Windows.Forms.ComboBox();
            this.btnShapeLft = new System.Windows.Forms.Button();
            this.btnShapeDown = new System.Windows.Forms.Button();
            this.btnShapeRgt = new System.Windows.Forms.Button();
            this.btnShapeUp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShapeIdx = new System.Windows.Forms.TextBox();
            this.btnMoveShapes = new System.Windows.Forms.Button();
            this.txtImageShapeFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddImageShape = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSaveToFilePath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveObjToFile = new System.Windows.Forms.Button();
            this.txtShapeCnt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.grpObjectSize.SuspendLayout();
            this.grbObjectTypes.SuspendLayout();
            this.grpProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Location = new System.Drawing.Point(1, 1);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(640, 480);
            this.pnlCanvas.TabIndex = 0;
            // 
            // rdoFixedSize
            // 
            this.rdoFixedSize.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoFixedSize.Checked = true;
            this.rdoFixedSize.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.rdoFixedSize.Location = new System.Drawing.Point(16, 74);
            this.rdoFixedSize.Name = "rdoFixedSize";
            this.rdoFixedSize.Size = new System.Drawing.Size(85, 24);
            this.rdoFixedSize.TabIndex = 1;
            this.rdoFixedSize.TabStop = true;
            this.rdoFixedSize.Text = "Setting Size";
            this.rdoFixedSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoFixedSize.UseVisualStyleBackColor = true;
            this.rdoFixedSize.CheckedChanged += new System.EventHandler(this.rdoObjectSize_CheckedChanged);
            // 
            // rdoUserSize
            // 
            this.rdoUserSize.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoUserSize.Enabled = false;
            this.rdoUserSize.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.rdoUserSize.Location = new System.Drawing.Point(103, 74);
            this.rdoUserSize.Name = "rdoUserSize";
            this.rdoUserSize.Size = new System.Drawing.Size(85, 24);
            this.rdoUserSize.TabIndex = 2;
            this.rdoUserSize.Text = "Mouse Drag";
            this.rdoUserSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoUserSize.UseVisualStyleBackColor = true;
            this.rdoUserSize.CheckedChanged += new System.EventHandler(this.rdoObjectSize_CheckedChanged);
            // 
            // grpObjectSize
            // 
            this.grpObjectSize.Controls.Add(this.label2);
            this.grpObjectSize.Controls.Add(this.label1);
            this.grpObjectSize.Controls.Add(this.txtSizeCy);
            this.grpObjectSize.Controls.Add(this.txtSizeCx);
            this.grpObjectSize.Controls.Add(this.rdoUserSize);
            this.grpObjectSize.Controls.Add(this.rdoFixedSize);
            this.grpObjectSize.Location = new System.Drawing.Point(647, 12);
            this.grpObjectSize.Name = "grpObjectSize";
            this.grpObjectSize.Size = new System.Drawing.Size(200, 108);
            this.grpObjectSize.TabIndex = 3;
            this.grpObjectSize.TabStop = false;
            this.grpObjectSize.Text = "Shape Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width";
            // 
            // txtSizeCy
            // 
            this.txtSizeCy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizeCy.Location = new System.Drawing.Point(103, 40);
            this.txtSizeCy.Name = "txtSizeCy";
            this.txtSizeCy.Size = new System.Drawing.Size(85, 22);
            this.txtSizeCy.TabIndex = 4;
            this.txtSizeCy.Text = "30";
            this.txtSizeCy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSizeCx
            // 
            this.txtSizeCx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizeCx.Location = new System.Drawing.Point(16, 40);
            this.txtSizeCx.Name = "txtSizeCx";
            this.txtSizeCx.Size = new System.Drawing.Size(85, 22);
            this.txtSizeCx.TabIndex = 3;
            this.txtSizeCx.Text = "30";
            this.txtSizeCx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbObjectTypes
            // 
            this.grbObjectTypes.Controls.Add(this.rdoObjEllipse);
            this.grbObjectTypes.Controls.Add(this.rdoObjRect);
            this.grbObjectTypes.Location = new System.Drawing.Point(646, 306);
            this.grbObjectTypes.Name = "grbObjectTypes";
            this.grbObjectTypes.Size = new System.Drawing.Size(200, 174);
            this.grbObjectTypes.TabIndex = 4;
            this.grbObjectTypes.TabStop = false;
            this.grbObjectTypes.Text = "Shape";
            // 
            // rdoObjEllipse
            // 
            this.rdoObjEllipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoObjEllipse.BackColor = System.Drawing.Color.DimGray;
            this.rdoObjEllipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.BlanchedAlmond;
            this.rdoObjEllipse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoObjEllipse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoObjEllipse.Location = new System.Drawing.Point(16, 69);
            this.rdoObjEllipse.Name = "rdoObjEllipse";
            this.rdoObjEllipse.Size = new System.Drawing.Size(172, 31);
            this.rdoObjEllipse.TabIndex = 3;
            this.rdoObjEllipse.Text = "Ellipse";
            this.rdoObjEllipse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoObjEllipse.UseVisualStyleBackColor = false;
            this.rdoObjEllipse.CheckedChanged += new System.EventHandler(this.rdoObjectType_CheckedChanged);
            // 
            // rdoObjRect
            // 
            this.rdoObjRect.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoObjRect.Checked = true;
            this.rdoObjRect.FlatAppearance.CheckedBackColor = System.Drawing.Color.BlanchedAlmond;
            this.rdoObjRect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoObjRect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoObjRect.Location = new System.Drawing.Point(16, 32);
            this.rdoObjRect.Name = "rdoObjRect";
            this.rdoObjRect.Size = new System.Drawing.Size(172, 31);
            this.rdoObjRect.TabIndex = 2;
            this.rdoObjRect.TabStop = true;
            this.rdoObjRect.Text = "Rectangle";
            this.rdoObjRect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoObjRect.UseVisualStyleBackColor = true;
            this.rdoObjRect.CheckedChanged += new System.EventHandler(this.rdoObjectType_CheckedChanged);
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.cbLineColor);
            this.grpProperty.Controls.Add(this.label5);
            this.grpProperty.Controls.Add(this.txtLineThick);
            this.grpProperty.Controls.Add(this.label4);
            this.grpProperty.Controls.Add(this.cbColor);
            this.grpProperty.Controls.Add(this.rdoEmpy);
            this.grpProperty.Controls.Add(this.rdoFill);
            this.grpProperty.Location = new System.Drawing.Point(647, 126);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(200, 174);
            this.grpProperty.TabIndex = 5;
            this.grpProperty.TabStop = false;
            this.grpProperty.Text = "Shape Property";
            // 
            // cbLineColor
            // 
            this.cbLineColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineColor.FormattingEnabled = true;
            this.cbLineColor.Location = new System.Drawing.Point(17, 46);
            this.cbLineColor.Name = "cbLineColor";
            this.cbLineColor.Size = new System.Drawing.Size(171, 22);
            this.cbLineColor.TabIndex = 14;
            this.cbLineColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Line Thick.";
            // 
            // txtLineThick
            // 
            this.txtLineThick.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineThick.Location = new System.Drawing.Point(101, 20);
            this.txtLineThick.Name = "txtLineThick";
            this.txtLineThick.Size = new System.Drawing.Size(85, 22);
            this.txtLineThick.TabIndex = 12;
            this.txtLineThick.Text = "1";
            this.txtLineThick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Brush";
            // 
            // cbColor
            // 
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(15, 138);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(171, 22);
            this.cbColor.TabIndex = 4;
            this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            // 
            // rdoEmpy
            // 
            this.rdoEmpy.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoEmpy.BackColor = System.Drawing.Color.DimGray;
            this.rdoEmpy.FlatAppearance.CheckedBackColor = System.Drawing.Color.BlanchedAlmond;
            this.rdoEmpy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoEmpy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEmpy.Location = new System.Drawing.Point(88, 97);
            this.rdoEmpy.Name = "rdoEmpy";
            this.rdoEmpy.Size = new System.Drawing.Size(67, 31);
            this.rdoEmpy.TabIndex = 3;
            this.rdoEmpy.Text = "Empy";
            this.rdoEmpy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoEmpy.UseVisualStyleBackColor = false;
            this.rdoEmpy.CheckedChanged += new System.EventHandler(this.rdoObjectProperty_CheckedChanged);
            // 
            // rdoFill
            // 
            this.rdoFill.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoFill.Checked = true;
            this.rdoFill.FlatAppearance.CheckedBackColor = System.Drawing.Color.BlanchedAlmond;
            this.rdoFill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoFill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFill.Location = new System.Drawing.Point(15, 97);
            this.rdoFill.Name = "rdoFill";
            this.rdoFill.Size = new System.Drawing.Size(67, 31);
            this.rdoFill.TabIndex = 2;
            this.rdoFill.TabStop = true;
            this.rdoFill.Text = "Fill";
            this.rdoFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoFill.UseVisualStyleBackColor = true;
            this.rdoFill.CheckedChanged += new System.EventHandler(this.rdoObjectProperty_CheckedChanged);
            // 
            // btnAddShape
            // 
            this.btnAddShape.Location = new System.Drawing.Point(129, 503);
            this.btnAddShape.Name = "btnAddShape";
            this.btnAddShape.Size = new System.Drawing.Size(92, 50);
            this.btnAddShape.TabIndex = 6;
            this.btnAddShape.Text = "Add Shape";
            this.btnAddShape.UseVisualStyleBackColor = true;
            this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
            // 
            // btnDeleteShape
            // 
            this.btnDeleteShape.Location = new System.Drawing.Point(223, 503);
            this.btnDeleteShape.Name = "btnDeleteShape";
            this.btnDeleteShape.Size = new System.Drawing.Size(92, 50);
            this.btnDeleteShape.TabIndex = 7;
            this.btnDeleteShape.Text = "Delete Shape";
            this.btnDeleteShape.UseVisualStyleBackColor = true;
            this.btnDeleteShape.Click += new System.EventHandler(this.btnDeleteShape_Click);
            // 
            // btnNewObj
            // 
            this.btnNewObj.Location = new System.Drawing.Point(12, 531);
            this.btnNewObj.Name = "btnNewObj";
            this.btnNewObj.Size = new System.Drawing.Size(109, 22);
            this.btnNewObj.TabIndex = 8;
            this.btnNewObj.Text = "Create Object";
            this.btnNewObj.UseVisualStyleBackColor = true;
            this.btnNewObj.Click += new System.EventHandler(this.btnNewObj_Click);
            // 
            // cbObjList
            // 
            this.cbObjList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjList.FormattingEnabled = true;
            this.cbObjList.Location = new System.Drawing.Point(12, 503);
            this.cbObjList.Name = "cbObjList";
            this.cbObjList.Size = new System.Drawing.Size(109, 23);
            this.cbObjList.TabIndex = 9;
            this.cbObjList.SelectedIndexChanged += new System.EventHandler(this.cbObjList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Objects List";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(317, 503);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(92, 50);
            this.btnComplete.TabIndex = 11;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Object Move Test";
            // 
            // btnTestObjMove
            // 
            this.btnTestObjMove.Location = new System.Drawing.Point(503, 525);
            this.btnTestObjMove.Name = "btnTestObjMove";
            this.btnTestObjMove.Size = new System.Drawing.Size(92, 23);
            this.btnTestObjMove.TabIndex = 13;
            this.btnTestObjMove.Text = "Start";
            this.btnTestObjMove.UseVisualStyleBackColor = true;
            this.btnTestObjMove.Click += new System.EventHandler(this.btnTestObjMove_Click);
            // 
            // btnObjOrgPos
            // 
            this.btnObjOrgPos.Location = new System.Drawing.Point(503, 554);
            this.btnObjOrgPos.Name = "btnObjOrgPos";
            this.btnObjOrgPos.Size = new System.Drawing.Size(92, 23);
            this.btnObjOrgPos.TabIndex = 14;
            this.btnObjOrgPos.Text = "Org. Pos";
            this.btnObjOrgPos.UseVisualStyleBackColor = true;
            this.btnObjOrgPos.Click += new System.EventHandler(this.btnObjOrgPos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 625);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Shape Inedex";
            // 
            // cbShapeIndex
            // 
            this.cbShapeIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShapeIndex.FormattingEnabled = true;
            this.cbShapeIndex.Location = new System.Drawing.Point(12, 643);
            this.cbShapeIndex.Name = "cbShapeIndex";
            this.cbShapeIndex.Size = new System.Drawing.Size(109, 23);
            this.cbShapeIndex.TabIndex = 15;
            this.cbShapeIndex.SelectedIndexChanged += new System.EventHandler(this.cbShapeIndex_SelectedIndexChanged);
            // 
            // btnShapeLft
            // 
            this.btnShapeLft.Location = new System.Drawing.Point(130, 640);
            this.btnShapeLft.Name = "btnShapeLft";
            this.btnShapeLft.Size = new System.Drawing.Size(53, 29);
            this.btnShapeLft.TabIndex = 17;
            this.btnShapeLft.Text = "Lft";
            this.btnShapeLft.UseVisualStyleBackColor = true;
            this.btnShapeLft.Click += new System.EventHandler(this.ShapeJogMove_Click);
            // 
            // btnShapeDown
            // 
            this.btnShapeDown.Location = new System.Drawing.Point(184, 640);
            this.btnShapeDown.Name = "btnShapeDown";
            this.btnShapeDown.Size = new System.Drawing.Size(53, 29);
            this.btnShapeDown.TabIndex = 18;
            this.btnShapeDown.Text = "Dwn";
            this.btnShapeDown.UseVisualStyleBackColor = true;
            this.btnShapeDown.Click += new System.EventHandler(this.ShapeJogMove_Click);
            // 
            // btnShapeRgt
            // 
            this.btnShapeRgt.Location = new System.Drawing.Point(238, 640);
            this.btnShapeRgt.Name = "btnShapeRgt";
            this.btnShapeRgt.Size = new System.Drawing.Size(53, 29);
            this.btnShapeRgt.TabIndex = 19;
            this.btnShapeRgt.Text = "Rgt";
            this.btnShapeRgt.UseVisualStyleBackColor = true;
            this.btnShapeRgt.Click += new System.EventHandler(this.ShapeJogMove_Click);
            // 
            // btnShapeUp
            // 
            this.btnShapeUp.Location = new System.Drawing.Point(185, 608);
            this.btnShapeUp.Name = "btnShapeUp";
            this.btnShapeUp.Size = new System.Drawing.Size(53, 29);
            this.btnShapeUp.TabIndex = 20;
            this.btnShapeUp.Text = "Up";
            this.btnShapeUp.UseVisualStyleBackColor = true;
            this.btnShapeUp.Click += new System.EventHandler(this.ShapeJogMove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Shapes Move Test(ex. 0,2,3,..,)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Shapes Idx:";
            // 
            // txtShapeIdx
            // 
            this.txtShapeIdx.Location = new System.Drawing.Point(685, 527);
            this.txtShapeIdx.Name = "txtShapeIdx";
            this.txtShapeIdx.Size = new System.Drawing.Size(162, 21);
            this.txtShapeIdx.TabIndex = 23;
            // 
            // btnMoveShapes
            // 
            this.btnMoveShapes.Location = new System.Drawing.Point(756, 554);
            this.btnMoveShapes.Name = "btnMoveShapes";
            this.btnMoveShapes.Size = new System.Drawing.Size(92, 23);
            this.btnMoveShapes.TabIndex = 24;
            this.btnMoveShapes.Text = "Start";
            this.btnMoveShapes.UseVisualStyleBackColor = true;
            this.btnMoveShapes.Click += new System.EventHandler(this.btnMoveShapes_Click);
            // 
            // txtImageShapeFile
            // 
            this.txtImageShapeFile.Location = new System.Drawing.Point(129, 560);
            this.txtImageShapeFile.Name = "txtImageShapeFile";
            this.txtImageShapeFile.Size = new System.Drawing.Size(280, 21);
            this.txtImageShapeFile.TabIndex = 25;
            this.txtImageShapeFile.Text = "D:\\Source\\RnD\\Test\\Graphics\\Images\\omron_amrLD.jpg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 563);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Image Shape File:";
            // 
            // btnAddImageShape
            // 
            this.btnAddImageShape.Location = new System.Drawing.Point(293, 587);
            this.btnAddImageShape.Name = "btnAddImageShape";
            this.btnAddImageShape.Size = new System.Drawing.Size(116, 24);
            this.btnAddImageShape.TabIndex = 27;
            this.btnAddImageShape.Text = "Add Img. Shape";
            this.btnAddImageShape.UseVisualStyleBackColor = true;
            this.btnAddImageShape.Click += new System.EventHandler(this.btnAddImageShape_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 621);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Save Path:";
            // 
            // txtSaveToFilePath
            // 
            this.txtSaveToFilePath.Location = new System.Drawing.Point(538, 619);
            this.txtSaveToFilePath.Name = "txtSaveToFilePath";
            this.txtSaveToFilePath.Size = new System.Drawing.Size(310, 21);
            this.txtSaveToFilePath.TabIndex = 28;
            this.txtSaveToFilePath.Text = "D:\\Source\\RnD\\Test\\Graphics\\shapeList\\Object1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 593);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Save Object To File";
            // 
            // btnSaveObjToFile
            // 
            this.btnSaveObjToFile.Location = new System.Drawing.Point(538, 645);
            this.btnSaveObjToFile.Name = "btnSaveObjToFile";
            this.btnSaveObjToFile.Size = new System.Drawing.Size(94, 24);
            this.btnSaveObjToFile.TabIndex = 31;
            this.btnSaveObjToFile.Text = "Save to File";
            this.btnSaveObjToFile.UseVisualStyleBackColor = true;
            this.btnSaveObjToFile.Click += new System.EventHandler(this.btnSaveObjToFile_Click);
            // 
            // txtShapeCnt
            // 
            this.txtShapeCnt.Location = new System.Drawing.Point(711, 646);
            this.txtShapeCnt.Name = "txtShapeCnt";
            this.txtShapeCnt.Size = new System.Drawing.Size(52, 21);
            this.txtShapeCnt.TabIndex = 32;
            this.txtShapeCnt.Text = "3";
            this.txtShapeCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(644, 649);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "ShapeCnt";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(769, 644);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(78, 24);
            this.btnLoadFile.TabIndex = 34;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // ObjectsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(858, 678);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtShapeCnt);
            this.Controls.Add(this.btnSaveObjToFile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSaveToFilePath);
            this.Controls.Add(this.btnAddImageShape);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtImageShapeFile);
            this.Controls.Add(this.btnMoveShapes);
            this.Controls.Add(this.txtShapeIdx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnShapeUp);
            this.Controls.Add(this.btnShapeRgt);
            this.Controls.Add(this.btnShapeDown);
            this.Controls.Add(this.btnShapeLft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbShapeIndex);
            this.Controls.Add(this.btnObjOrgPos);
            this.Controls.Add(this.btnTestObjMove);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbObjList);
            this.Controls.Add(this.btnNewObj);
            this.Controls.Add(this.btnDeleteShape);
            this.Controls.Add(this.btnAddShape);
            this.Controls.Add(this.grpProperty);
            this.Controls.Add(this.grbObjectTypes);
            this.Controls.Add(this.grpObjectSize);
            this.Controls.Add(this.pnlCanvas);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ObjectsSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Objects Setting";
            this.TopMost = true;
            this.grpObjectSize.ResumeLayout(false);
            this.grpObjectSize.PerformLayout();
            this.grbObjectTypes.ResumeLayout(false);
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.RadioButton rdoFixedSize;
        private System.Windows.Forms.RadioButton rdoUserSize;
        private System.Windows.Forms.GroupBox grpObjectSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSizeCy;
        private System.Windows.Forms.TextBox txtSizeCx;
        private System.Windows.Forms.GroupBox grbObjectTypes;
        private System.Windows.Forms.RadioButton rdoObjEllipse;
        private System.Windows.Forms.RadioButton rdoObjRect;
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.RadioButton rdoEmpy;
        private System.Windows.Forms.RadioButton rdoFill;
        private System.Windows.Forms.Button btnAddShape;
        private System.Windows.Forms.Button btnDeleteShape;
        private System.Windows.Forms.Button btnNewObj;
        private System.Windows.Forms.ComboBox cbObjList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLineColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLineThick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTestObjMove;
        private System.Windows.Forms.Button btnObjOrgPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbShapeIndex;
        private System.Windows.Forms.Button btnShapeLft;
        private System.Windows.Forms.Button btnShapeDown;
        private System.Windows.Forms.Button btnShapeRgt;
        private System.Windows.Forms.Button btnShapeUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShapeIdx;
        private System.Windows.Forms.Button btnMoveShapes;
        private System.Windows.Forms.TextBox txtImageShapeFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddImageShape;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSaveToFilePath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveObjToFile;
        private System.Windows.Forms.TextBox txtShapeCnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLoadFile;
    }
}