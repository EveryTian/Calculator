namespace Calc
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科学计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPlu = new System.Windows.Forms.Button();
            this.btnSq = new System.Windows.Forms.Button();
            this.btnBksp = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnNeg = new System.Windows.Forms.Button();
            this.btnRcp = new System.Windows.Forms.Button();
            this.btnRt = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.labelResultFullPrompt = new System.Windows.Forms.Label();
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.btnLbrk = new System.Windows.Forms.Button();
            this.btnRbrk = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.labelLbrkPrompt = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换ToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // 切换ToolStripMenuItem
            // 
            this.切换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通计算器ToolStripMenuItem,
            this.科学计算器ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出程序ToolStripMenuItem});
            this.切换ToolStripMenuItem.Name = "切换ToolStripMenuItem";
            this.切换ToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.切换ToolStripMenuItem.Text = "菜单(&M)";
            // 
            // 普通计算器ToolStripMenuItem
            // 
            this.普通计算器ToolStripMenuItem.Name = "普通计算器ToolStripMenuItem";
            this.普通计算器ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.普通计算器ToolStripMenuItem.Text = "普通计算器";
            this.普通计算器ToolStripMenuItem.Click += new System.EventHandler(this.普通计算器ToolStripMenuItem_Click);
            // 
            // 科学计算器ToolStripMenuItem
            // 
            this.科学计算器ToolStripMenuItem.Name = "科学计算器ToolStripMenuItem";
            this.科学计算器ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.科学计算器ToolStripMenuItem.Text = "科学计算器";
            this.科学计算器ToolStripMenuItem.Click += new System.EventHandler(this.科学计算器ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.退出程序ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于本计算器ToolStripMenuItem});
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // 关于本计算器ToolStripMenuItem
            // 
            this.关于本计算器ToolStripMenuItem.Name = "关于本计算器ToolStripMenuItem";
            this.关于本计算器ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于本计算器ToolStripMenuItem.Text = "关于本计算器";
            this.关于本计算器ToolStripMenuItem.Click += new System.EventHandler(this.关于本计算器ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn0.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(10, 321);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 34);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(10, 279);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 34);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(62, 279);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 34);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(112, 279);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 34);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn5.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(62, 238);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 34);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn7.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(10, 197);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 34);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn6.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(112, 238);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 34);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(10, 238);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 34);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDot.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.Location = new System.Drawing.Point(112, 321);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(45, 34);
            this.btnDot.TabIndex = 12;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn8.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(62, 197);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 34);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn9.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(112, 197);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 34);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(214, 279);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(45, 75);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "＝";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.Black;
            this.btnDiv.Location = new System.Drawing.Point(164, 197);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 34);
            this.btnDiv.TabIndex = 16;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.ForeColor = System.Drawing.Color.Black;
            this.btnMul.Location = new System.Drawing.Point(164, 238);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(45, 34);
            this.btnMul.TabIndex = 15;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Black;
            this.btnMin.Location = new System.Drawing.Point(164, 279);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(45, 34);
            this.btnMin.TabIndex = 14;
            this.btnMin.Text = "－";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnPlu
            // 
            this.btnPlu.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlu.ForeColor = System.Drawing.Color.Black;
            this.btnPlu.Location = new System.Drawing.Point(164, 321);
            this.btnPlu.Name = "btnPlu";
            this.btnPlu.Size = new System.Drawing.Size(45, 34);
            this.btnPlu.TabIndex = 13;
            this.btnPlu.Text = "＋";
            this.btnPlu.UseVisualStyleBackColor = true;
            this.btnPlu.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnSq
            // 
            this.btnSq.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.btnSq.ForeColor = System.Drawing.Color.Black;
            this.btnSq.Location = new System.Drawing.Point(214, 197);
            this.btnSq.Name = "btnSq";
            this.btnSq.Size = new System.Drawing.Size(45, 34);
            this.btnSq.TabIndex = 22;
            this.btnSq.Text = "X^2";
            this.btnSq.UseVisualStyleBackColor = true;
            this.btnSq.Click += new System.EventHandler(this.btnSq_Click);
            // 
            // btnBksp
            // 
            this.btnBksp.Font = new System.Drawing.Font("Yu Gothic", 8F);
            this.btnBksp.ForeColor = System.Drawing.Color.Black;
            this.btnBksp.Location = new System.Drawing.Point(112, 158);
            this.btnBksp.Name = "btnBksp";
            this.btnBksp.Size = new System.Drawing.Size(45, 34);
            this.btnBksp.TabIndex = 19;
            this.btnBksp.Text = "BKSP";
            this.btnBksp.UseVisualStyleBackColor = true;
            this.btnBksp.Click += new System.EventHandler(this.btnBksp_Click);
            // 
            // btnCe
            // 
            this.btnCe.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.btnCe.ForeColor = System.Drawing.Color.Black;
            this.btnCe.Location = new System.Drawing.Point(10, 158);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(45, 34);
            this.btnCe.TabIndex = 17;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Location = new System.Drawing.Point(62, 158);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(45, 34);
            this.btnC.TabIndex = 18;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnNeg
            // 
            this.btnNeg.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.btnNeg.ForeColor = System.Drawing.Color.Black;
            this.btnNeg.Location = new System.Drawing.Point(164, 158);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(45, 34);
            this.btnNeg.TabIndex = 20;
            this.btnNeg.Text = "NEG";
            this.btnNeg.UseVisualStyleBackColor = true;
            this.btnNeg.Click += new System.EventHandler(this.butNeg_Click);
            // 
            // btnRcp
            // 
            this.btnRcp.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.btnRcp.ForeColor = System.Drawing.Color.Black;
            this.btnRcp.Location = new System.Drawing.Point(214, 238);
            this.btnRcp.Name = "btnRcp";
            this.btnRcp.Size = new System.Drawing.Size(45, 34);
            this.btnRcp.TabIndex = 23;
            this.btnRcp.Text = "1/X";
            this.btnRcp.UseVisualStyleBackColor = true;
            this.btnRcp.Click += new System.EventHandler(this.btnRcp_Click);
            // 
            // btnRt
            // 
            this.btnRt.Font = new System.Drawing.Font("Yu Gothic", 8F);
            this.btnRt.ForeColor = System.Drawing.Color.Black;
            this.btnRt.Location = new System.Drawing.Point(214, 158);
            this.btnRt.Name = "btnRt";
            this.btnRt.Size = new System.Drawing.Size(45, 34);
            this.btnRt.TabIndex = 21;
            this.btnRt.Text = "SQRT";
            this.btnRt.UseVisualStyleBackColor = true;
            this.btnRt.Click += new System.EventHandler(this.btnRt_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Gainsboro;
            this.labelState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.Black;
            this.labelState.Location = new System.Drawing.Point(6, 17);
            this.labelState.Name = "labelState";
            this.labelState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelState.Size = new System.Drawing.Size(0, 21);
            this.labelState.TabIndex = 25;
            this.labelState.TextChanged += new System.EventHandler(this.labelState_TextChanged);
            this.labelState.MouseHover += new System.EventHandler(this.labelState_MouseHover);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Black;
            this.labelResult.Location = new System.Drawing.Point(0, 57);
            this.labelResult.Name = "labelResult";
            this.labelResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelResult.Size = new System.Drawing.Size(30, 35);
            this.labelResult.TabIndex = 26;
            this.labelResult.Text = "0";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResult.TextChanged += new System.EventHandler(this.labelResult_TextChanged);
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxDisplay.Controls.Add(this.labelResult);
            this.groupBoxDisplay.Controls.Add(this.labelResultFullPrompt);
            this.groupBoxDisplay.Controls.Add(this.labelState);
            this.groupBoxDisplay.Controls.Add(this.richTextBoxDisplay);
            this.groupBoxDisplay.Location = new System.Drawing.Point(12, 36);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(315, 99);
            this.groupBoxDisplay.TabIndex = 0;
            this.groupBoxDisplay.TabStop = false;
            // 
            // labelResultFullPrompt
            // 
            this.labelResultFullPrompt.AutoSize = true;
            this.labelResultFullPrompt.BackColor = System.Drawing.Color.Gainsboro;
            this.labelResultFullPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultFullPrompt.ForeColor = System.Drawing.Color.Black;
            this.labelResultFullPrompt.Location = new System.Drawing.Point(6, 79);
            this.labelResultFullPrompt.Name = "labelResultFullPrompt";
            this.labelResultFullPrompt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelResultFullPrompt.Size = new System.Drawing.Size(204, 19);
            this.labelResultFullPrompt.TabIndex = 27;
            this.labelResultFullPrompt.Text = "（如需获取完整显示请点击此处）";
            this.labelResultFullPrompt.Visible = false;
            this.labelResultFullPrompt.Click += new System.EventHandler(this.resultFullPrompt_Click);
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.BackColor = System.Drawing.Color.Bisque;
            this.richTextBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDisplay.Location = new System.Drawing.Point(8, 13);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(302, 75);
            this.richTextBoxDisplay.TabIndex = 28;
            this.richTextBoxDisplay.Text = "";
            this.richTextBoxDisplay.Visible = false;
            this.richTextBoxDisplay.MouseLeave += new System.EventHandler(this.richTextBoxDisplay_MouseLeave);
            // 
            // btnLbrk
            // 
            this.btnLbrk.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLbrk.ForeColor = System.Drawing.Color.Black;
            this.btnLbrk.Location = new System.Drawing.Point(10, 158);
            this.btnLbrk.Name = "btnLbrk";
            this.btnLbrk.Size = new System.Drawing.Size(45, 34);
            this.btnLbrk.TabIndex = 24;
            this.btnLbrk.Text = "(";
            this.btnLbrk.UseVisualStyleBackColor = true;
            this.btnLbrk.Visible = false;
            this.btnLbrk.Click += new System.EventHandler(this.btnLbrk_Click);
            // 
            // btnRbrk
            // 
            this.btnRbrk.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRbrk.ForeColor = System.Drawing.Color.Black;
            this.btnRbrk.Location = new System.Drawing.Point(62, 158);
            this.btnRbrk.Name = "btnRbrk";
            this.btnRbrk.Size = new System.Drawing.Size(45, 34);
            this.btnRbrk.TabIndex = 25;
            this.btnRbrk.Text = ")";
            this.btnRbrk.UseVisualStyleBackColor = true;
            this.btnRbrk.Visible = false;
            this.btnRbrk.Click += new System.EventHandler(this.btnRbrk_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.btnSin.ForeColor = System.Drawing.Color.Black;
            this.btnSin.Location = new System.Drawing.Point(282, 197);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(45, 34);
            this.btnSin.TabIndex = 26;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.btnCos.ForeColor = System.Drawing.Color.Black;
            this.btnCos.Location = new System.Drawing.Point(282, 238);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(45, 34);
            this.btnCos.TabIndex = 27;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.btnTan.ForeColor = System.Drawing.Color.Black;
            this.btnTan.Location = new System.Drawing.Point(282, 279);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(45, 34);
            this.btnTan.TabIndex = 28;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Location = new System.Drawing.Point(282, 321);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(45, 34);
            this.btnLog.TabIndex = 29;
            this.btnLog.Text = "lg";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnShift
            // 
            this.btnShift.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.ForeColor = System.Drawing.Color.Black;
            this.btnShift.Location = new System.Drawing.Point(282, 161);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(45, 22);
            this.btnShift.TabIndex = 30;
            this.btnShift.Text = "↑";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // labelLbrkPrompt
            // 
            this.labelLbrkPrompt.AutoSize = true;
            this.labelLbrkPrompt.Font = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLbrkPrompt.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLbrkPrompt.Location = new System.Drawing.Point(13, 161);
            this.labelLbrkPrompt.Name = "labelLbrkPrompt";
            this.labelLbrkPrompt.Size = new System.Drawing.Size(0, 8);
            this.labelLbrkPrompt.TabIndex = 31;
            this.labelLbrkPrompt.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 365);
            this.Controls.Add(this.labelLbrkPrompt);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.btnLbrk);
            this.Controls.Add(this.btnRbrk);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.groupBoxDisplay);
            this.Controls.Add(this.btnBksp);
            this.Controls.Add(this.btnRt);
            this.Controls.Add(this.btnRcp);
            this.Controls.Add(this.btnNeg);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnSq);
            this.Controls.Add(this.btnPlu);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "计算器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDisplay.ResumeLayout(false);
            this.groupBoxDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 切换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科学计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本计算器ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlu;
        private System.Windows.Forms.Button btnSq;
        private System.Windows.Forms.Button btnBksp;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnNeg;
        private System.Windows.Forms.Button btnRcp;
        private System.Windows.Forms.Button btnRt;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnLbrk;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnRbrk;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Label labelResultFullPrompt;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.Label labelLbrkPrompt;
    }
}

