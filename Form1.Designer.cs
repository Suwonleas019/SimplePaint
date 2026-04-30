namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppname = new Label();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            picCanvas = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // lblAppname
            // 
            lblAppname.AutoSize = true;
            lblAppname.Font = new Font("맑은 고딕", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppname.ForeColor = Color.Blue;
            lblAppname.Location = new Point(39, 18);
            lblAppname.Name = "lblAppname";
            lblAppname.Size = new Size(310, 67);
            lblAppname.TabIndex = 0;
            lblAppname.Text = "SimplePaint";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(48, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(267, 26);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(108, 71);
            btnCircle.TabIndex = 4;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(145, 26);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(102, 71);
            btnRectangle.TabIndex = 3;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(27, 26);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(100, 71);
            btnLine.TabIndex = 2;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(480, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 125);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black  검정", "Red    빨강", "Blue   파랑", "Green 녹색" });
            cmbColor.Location = new Point(6, 40);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(151, 28);
            cmbColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(675, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(167, 125);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(19, 40);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(130, 56);
            trbLineWidth.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = SystemColors.Info;
            btnOpenFile.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(857, 88);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(135, 111);
            btnOpenFile.TabIndex = 7;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = SystemColors.GradientActiveCaption;
            btnSaveFile.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(1007, 88);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(135, 111);
            btnSaveFile.TabIndex = 8;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(75, 219);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1094, 487);
            picCanvas.TabIndex = 9;
            picCanvas.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 739);
            Controls.Add(picCanvas);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppname);
            Name = "Form1";
            Text = "SimplePaint v1.0";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppname;
        private GroupBox groupBox1;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private GroupBox groupBox2;
        private ComboBox cmbColor;
        private GroupBox groupBox3;
        private TrackBar trbLineWidth;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private PictureBox picCanvas;
    }
}
