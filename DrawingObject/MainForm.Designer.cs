namespace DrawingObject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtShapeCnt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoadFilePath = new System.Windows.Forms.TextBox();
            this.txtStgY1Idx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovStgY1 = new System.Windows.Forms.TextBox();
            this.btnMovStgY1 = new System.Windows.Forms.Button();
            this.btnMovStgY2 = new System.Windows.Forms.Button();
            this.txtMovStgY2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStgY2Idx = new System.Windows.Forms.TextBox();
            this.btnMovStgX = new System.Windows.Forms.Button();
            this.txtMovStgX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStgXIdx = new System.Windows.Forms.TextBox();
            this.btnRegAnimate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDrawing.Location = new System.Drawing.Point(1, 1);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(797, 489);
            this.pnlDrawing.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Object 설정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(717, 550);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(78, 24);
            this.btnLoadFile.TabIndex = 39;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(592, 555);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "ShapeCnt";
            // 
            // txtShapeCnt
            // 
            this.txtShapeCnt.Location = new System.Drawing.Point(659, 552);
            this.txtShapeCnt.Name = "txtShapeCnt";
            this.txtShapeCnt.Size = new System.Drawing.Size(52, 21);
            this.txtShapeCnt.TabIndex = 37;
            this.txtShapeCnt.Text = "8";
            this.txtShapeCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "Object Load Path:";
            // 
            // txtLoadFilePath
            // 
            this.txtLoadFilePath.Location = new System.Drawing.Point(461, 525);
            this.txtLoadFilePath.Name = "txtLoadFilePath";
            this.txtLoadFilePath.Size = new System.Drawing.Size(335, 21);
            this.txtLoadFilePath.TabIndex = 35;
            this.txtLoadFilePath.Text = "D:\\Source\\RnD\\Test\\Graphics\\shapeList\\Object1";
            // 
            // txtStgY1Idx
            // 
            this.txtStgY1Idx.Location = new System.Drawing.Point(47, 504);
            this.txtStgY1Idx.Name = "txtStgY1Idx";
            this.txtStgY1Idx.Size = new System.Drawing.Size(82, 21);
            this.txtStgY1Idx.TabIndex = 40;
            this.txtStgY1Idx.Text = "3";
            this.txtStgY1Idx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "StgY1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "MovY:";
            // 
            // txtMovStgY1
            // 
            this.txtMovStgY1.Location = new System.Drawing.Point(47, 540);
            this.txtMovStgY1.Name = "txtMovStgY1";
            this.txtMovStgY1.Size = new System.Drawing.Size(82, 21);
            this.txtMovStgY1.TabIndex = 43;
            this.txtMovStgY1.Text = "-200";
            this.txtMovStgY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMovStgY1
            // 
            this.btnMovStgY1.Location = new System.Drawing.Point(47, 561);
            this.btnMovStgY1.Name = "btnMovStgY1";
            this.btnMovStgY1.Size = new System.Drawing.Size(82, 23);
            this.btnMovStgY1.TabIndex = 44;
            this.btnMovStgY1.Text = "Moving";
            this.btnMovStgY1.UseVisualStyleBackColor = true;
            this.btnMovStgY1.Click += new System.EventHandler(this.btnMovStgY1_Click);
            // 
            // btnMovStgY2
            // 
            this.btnMovStgY2.Location = new System.Drawing.Point(173, 562);
            this.btnMovStgY2.Name = "btnMovStgY2";
            this.btnMovStgY2.Size = new System.Drawing.Size(82, 23);
            this.btnMovStgY2.TabIndex = 49;
            this.btnMovStgY2.Text = "Moving";
            this.btnMovStgY2.UseVisualStyleBackColor = true;
            this.btnMovStgY2.Click += new System.EventHandler(this.btnMovStgY2_Click);
            // 
            // txtMovStgY2
            // 
            this.txtMovStgY2.Location = new System.Drawing.Point(173, 541);
            this.txtMovStgY2.Name = "txtMovStgY2";
            this.txtMovStgY2.Size = new System.Drawing.Size(82, 21);
            this.txtMovStgY2.TabIndex = 48;
            this.txtMovStgY2.Text = "-200";
            this.txtMovStgY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "MovY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "StgY2:";
            // 
            // txtStgY2Idx
            // 
            this.txtStgY2Idx.Location = new System.Drawing.Point(173, 505);
            this.txtStgY2Idx.Name = "txtStgY2Idx";
            this.txtStgY2Idx.Size = new System.Drawing.Size(82, 21);
            this.txtStgY2Idx.TabIndex = 45;
            this.txtStgY2Idx.Text = "4";
            this.txtStgY2Idx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMovStgX
            // 
            this.btnMovStgX.Location = new System.Drawing.Point(312, 562);
            this.btnMovStgX.Name = "btnMovStgX";
            this.btnMovStgX.Size = new System.Drawing.Size(82, 23);
            this.btnMovStgX.TabIndex = 54;
            this.btnMovStgX.Text = "Moving";
            this.btnMovStgX.UseVisualStyleBackColor = true;
            this.btnMovStgX.Click += new System.EventHandler(this.btnMovStgX_Click);
            // 
            // txtMovStgX
            // 
            this.txtMovStgX.Location = new System.Drawing.Point(312, 541);
            this.txtMovStgX.Name = "txtMovStgX";
            this.txtMovStgX.Size = new System.Drawing.Size(82, 21);
            this.txtMovStgX.TabIndex = 53;
            this.txtMovStgX.Text = "160";
            this.txtMovStgX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "MovY:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 51;
            this.label6.Text = "StgX :";
            // 
            // txtStgXIdx
            // 
            this.txtStgXIdx.Location = new System.Drawing.Point(312, 505);
            this.txtStgXIdx.Name = "txtStgXIdx";
            this.txtStgXIdx.Size = new System.Drawing.Size(82, 21);
            this.txtStgXIdx.TabIndex = 50;
            this.txtStgXIdx.Text = "6,7";
            this.txtStgXIdx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegAnimate
            // 
            this.btnRegAnimate.Location = new System.Drawing.Point(398, 503);
            this.btnRegAnimate.Name = "btnRegAnimate";
            this.btnRegAnimate.Size = new System.Drawing.Size(60, 79);
            this.btnRegAnimate.TabIndex = 55;
            this.btnRegAnimate.Text = "Reg. Animate";
            this.btnRegAnimate.UseVisualStyleBackColor = true;
            this.btnRegAnimate.Click += new System.EventHandler(this.btnRegAnimate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.btnRegAnimate);
            this.Controls.Add(this.btnMovStgX);
            this.Controls.Add(this.txtMovStgX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStgXIdx);
            this.Controls.Add(this.btnMovStgY2);
            this.Controls.Add(this.txtMovStgY2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStgY2Idx);
            this.Controls.Add(this.btnMovStgY1);
            this.Controls.Add(this.txtMovStgY1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStgY1Idx);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtShapeCnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLoadFilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlDrawing);
            this.Name = "MainForm";
            this.Text = "Drawing Object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtShapeCnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLoadFilePath;
        private System.Windows.Forms.TextBox txtStgY1Idx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovStgY1;
        private System.Windows.Forms.Button btnMovStgY1;
        private System.Windows.Forms.Button btnMovStgY2;
        private System.Windows.Forms.TextBox txtMovStgY2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStgY2Idx;
        private System.Windows.Forms.Button btnMovStgX;
        private System.Windows.Forms.TextBox txtMovStgX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStgXIdx;
        private System.Windows.Forms.Button btnRegAnimate;
    }
}

