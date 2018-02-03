using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class mainForm : Form
    {
        string state = "";
        string result = "0";
        bool isStandard = true; // 是否为普通计算器
        // 普通计算器模式：
        bool isKeepResult = false; // 是否记录上一次运算结果用于下一次运算，并用于计算新的process
        int process = 0; // 0, 1, 2, 3 表示输入第一个数、运算符号、第二个数及运算完成
        double[] numop = new double[3];
        char opt; // 运算符
        // 科学计算器模式：
        bool isShift = false; // 是否为Shift模式
        bool isFinished = false; // 是否完成运算
        int singleBrk = 0; // 记录多余的左括号数
        string opState = "";

        public mainForm()
        {
            InitializeComponent();
            richTextBoxDisplay.Visible = labelResultFullPrompt.Visible = false;
            普通计算器ToolStripMenuItem_Click(null, null); // default
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 普通计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLbrk.Visible = btnRbrk.Visible = false;
            Width = 285;
            groupBoxDisplay.Width = 245;
            richTextBoxDisplay.Width = 232;
            btnRcp.Visible = btnC.Visible = btnCe.Visible = true;
            btnDiv.Text = "÷";
            btnRt.Text = "SQRT";
            btnSq.Text = "X^2";
            labelState.Text = state = "";
            labelResult.Text = result = "0";
            process = 0;
            opt = '\0';
            numop[0] = numop[1] = numop[2] = 0;
            isStandard = true;
        }

        private void 科学计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRcp.Visible = btnC.Visible = btnCe.Visible = false;
            Width = 355;
            groupBoxDisplay.Width = 315;
            richTextBoxDisplay.Width = 302;
            btnLbrk.Visible = btnRbrk.Visible = true;
            btnDiv.Text = "/";
            btnRt.Text = "X√Y";
            btnSq.Text = "^";
            labelState.Text = state = opState = "";
            labelResult.Text = result = "0";
            isStandard = false;

        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                return;
            }
            if (!isShift)
            {
                btnSin.Text = "asin";
                btnCos.Text = "acos";
                btnTan.Text = "atan";
                btnLog.Text = "ln";
                btnShift.ForeColor = Color.Red;
                isShift = true;
            }
            else
            {
                btnSin.Text = "sin";
                btnCos.Text = "cos";
                btnTan.Text = "tan";
                btnLog.Text = "lg";
                btnShift.ForeColor = Color.Black;
                isShift = false;
            }
        }

        // For btn0 ~ btn9
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;
            if (isStandard)
            {
                if (isKeepResult)
                {
                    isKeepResult = false;
                    process = 0;
                    labelState.Text = state = "";
                    labelResult.Text = result = "0";
                }
                else if (process == 1)
                {
                    labelResult.Text = result = "0";
                    process = 2;
                }
                if (result == "0")
                {
                    if (senderBtn.Text == "0")
                    {
                        return;
                    }
                    result = senderBtn.Text;

                }
                else
                {
                    result += senderBtn.Text;
                }
                labelResult.Text = result;
                return;
            }
            else
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                }
                opState += senderBtn.Text;
                labelState.Text = state = viState(opState);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                if (isKeepResult)
                {
                    return;
                }
                if (process == 1)
                {
                    result = "0.";
                    labelResult.Text = result;
                    process = 2;
                    return;
                }
                if (result.Contains("."))
                {
                    return;
                }
                result += ".";
                labelResult.Text = result;
                return;
            }
            else
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                }
                opState += ".";
                labelState.Text = state = viState(opState);
            }
        }

        private void butNeg_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                if (process == 1)
                {
                    return;
                }
                if (Convert.ToDouble(result) == 0)
                {
                    return;
                }
                if (result[0] == '-')
                {
                    result = result.TrimStart('-');
                }
                else
                {
                    result = result.Insert(0, "-");
                }
                labelResult.Text = result;
                return;
            }
            else
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                }
                btnLbrk_Click(null, null);
                opState += (" -");
                labelState.Text = state = viState(opState);
            }
        }

        private void btnBksp_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                if (process == 1)
                {
                    return;
                }
                if (result.Length == 1)
                {
                    if (result == "0")
                    {
                        return;
                    }
                    else
                    {
                        result = "0";
                    }
                }
                else
                {
                    result = result.Remove(result.Length - 1);
                }
                if (result == "-")
                {
                    result = "0";
                }
                labelResult.Text = result;
                return;
            }
            else
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                    return;
                }
                opState = opState.TrimEnd();
                if (opState == "")
                {
                    return;
                }
                if (opState[opState.Length - 1] == '(')
                {
                    if (--singleBrk == 0)
                    {
                        labelLbrkPrompt.Visible = false;
                    }
                    labelLbrkPrompt.Text = Convert.ToString(singleBrk);
                }
                else if (opState[opState.Length - 1] == ')')
                {
                    labelLbrkPrompt.Visible = true;
                    labelLbrkPrompt.Text = Convert.ToString(++singleBrk);
                }
                opState = opState.Remove(opState.Length - 1);
                opState = opState.TrimEnd();
                labelState.Text = state = viState(opState);
            }
        }

        private void labelResult_TextChanged(object sender, EventArgs e)
        {
            int length = labelResult.Text.Length;
            labelResultFullPrompt.Visible = false;
            int border = isStandard ? 16 : 20;
            if (length <= border)
            {
                if (labelResult.Font.Size == 20.25)
                {
                    return;
                }
                else
                {
                    labelResult.Font = new Font(labelResult.Font.Name, 20.25F);
                }
            }
            else if (length > border && length <= (isStandard ? 30 : 36)) // 计划最大显示30, 36
            {
                float newSize = (isStandard ? 245F : 315F) / length * 1.25F;
                labelResult.Font = new Font(labelResult.Font.Name, newSize);
            }
            else
            {
                labelResultFullPrompt.Visible = true;
            }
        }

        private void resultFullPrompt_Click(object sender, EventArgs e)
        {
            float newSize = (isStandard? 245F: 315F) / labelResult.Text.Length;
            labelResult.Font = new Font(labelResult.Font.Name, newSize);
        }

        private void labelState_MouseHover(object sender, EventArgs e)
        {
            labelState.Visible = labelResult.Visible = labelResultFullPrompt.Visible = false;
            richTextBoxDisplay.Visible = true;
            richTextBoxDisplay.Text = state + "\n\n" + result;
        }

        private void richTextBoxDisplay_MouseLeave(object sender, EventArgs e)
        {
            richTextBoxDisplay.Visible = labelResultFullPrompt.Visible = false;
            labelState.Visible = labelResult.Visible = true;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                labelResult.Text = result = "0";
                numop[process] = 0;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if(isStandard)
            {
                if (process == 1)
                {
                    return;
                }
                labelResult.Text = result = "0";
                labelState.Text = state = "";
                numop[0] = numop[1] = numop[2] = 0;
                process = (process == 0) ? 0 : 1;
                opt = '\0';
            }
        }

        private void btnRt_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                if (process == 1)
                {
                    return;
                }
                result = Convert.ToString(Math.Sqrt(Convert.ToDouble(result)));
                labelResult.Text = result;
                return;
            }
            else
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                }
                if (state == "")
                {
                    return;
                }
                opState += " q";
                btnLbrk_Click(null, null);
            }
        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                if (process == 1)
                {
                    return;
                }
                result = Convert.ToString(Convert.ToDouble(result) * Convert.ToDouble(result));
                labelResult.Text = result;
                return;
            }
            else
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                }
                if (state == "")
                {
                    return;
                }
                opState += " ^";
                btnLbrk_Click(null, null);
            }
        }

        private void btnRcp_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                if (process == 1)
                {
                    return;
                }
                result = Convert.ToString(1 / Convert.ToDouble(result));
                labelResult.Text = result;
                return;
            }
        }

        // For btnPlu, Min, Mul, Div
        private void btnOp_Click(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;
            char op;
            if (senderBtn.Text == "＋")
            {
                op = '+';
            }
            else if (senderBtn.Text == "－")
            {
                op = '-';
            }
            else if (senderBtn.Text == "×")
            {
                op = '*';
            }
            else
            {
                op = '/';
            }
            if (isStandard)
            {
                if (isKeepResult)
                {
                    process = 0;
                    isKeepResult = false;
                }
                if (process == 1)
                {
                    opt = op;
                    state = state.Remove(state.Length - 1) + Convert.ToString(opt);
                    labelState.Text = state;
                }
                else if (process == 0)
                {
                    opt = op;
                    state = result + Convert.ToString(opt);
                    labelState.Text = state;
                    numop[0] = Convert.ToDouble(result);
                    process = 1;
                }
                else
                {
                    if (isFinished)
                    {
                        return;
                    }
                    btnCalc_Click(btnCalc, null);
                    btnOp_Click(sender, null);
                }
            }
            else
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                    return;
                }
                if (state == "")
                {
                    return;
                }
                opState += (" " + Convert.ToString(op) + " ");
                labelState.Text = state = viState(opState);
            }
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                if (process != 2)
                {
                    return;
                }
                numop[2] = Convert.ToDouble(result);
                labelState.Text = state = state + result;
                labelResult.Text = result = Convert.ToString(CalcStandard(numop[0], numop[2], opt));
                numop[1] = numop[2];
                isKeepResult = true;
                process = 3;
                return;
            }
            else
            {
                while (singleBrk != 0)
                {
                    btnRbrk_Click(null, null);
                }
                labelResult.Text = result = CalcSent(opState);
                labelState_TextChanged(null, null);
                isFinished = true;
            }
        }

        static double CalcStandard(double optnum1, double optnum2, char opt)
        {
            switch (opt)
            {
                case '+':
                    return optnum1 + optnum2;
                case '-':
                    return optnum1 - optnum2;
                case '*':
                    return optnum1 * optnum2;
                case '/':
                    return optnum1 / optnum2;
                default:
                    return 1D / 0D; // Error; 程序不会到达此处
            }
        }

        // 返回便于阅读的算式
        static string viState(string opState)
        {
            string state = opState.Replace(" ", "");
            state = state.Replace("s", "sin");
            state = state.Replace("c", "cos");
            state = state.Replace("t", "tan");
            state = state.Replace("S", "arcsin");
            state = state.Replace("C", "arccos");
            state = state.Replace("T", "arctan");
            state = state.Replace("q", "x√");
            state = state.Replace("l", "lg");
            state = state.Replace("L", "ln");
            return state;
        }
        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    btnNum_Click(btn0, null);
                    return;
                case Keys.NumPad1:
                case Keys.D1:
                    btnNum_Click(btn1, null);
                    return;
                case Keys.NumPad2:
                case Keys.D2:
                    btnNum_Click(btn2, null);
                    return;
                case Keys.NumPad3:
                case Keys.D3:
                    btnNum_Click(btn3, null);
                    return;
                case Keys.NumPad4:
                case Keys.D4:
                    btnNum_Click(btn4, null);
                    return;
                case Keys.NumPad5:
                case Keys.D5:
                    btnNum_Click(btn5, null);
                    return;
                case Keys.NumPad6:
                case Keys.D6:
                    btnNum_Click(btn6, null);
                    return;
                case Keys.NumPad7:
                case Keys.D7:
                    btnNum_Click(btn7, null);
                    return;
                case Keys.NumPad8:
                case Keys.D8:
                    btnNum_Click(btn8, null);
                    return;
                case Keys.NumPad9:
                case Keys.D9:
                    btnNum_Click(btn9, null);
                    return;
                case Keys.Decimal:
                    btnDot_Click(btnDot, null);
                    return;
                case Keys.Back:
                    btnBksp_Click(btnBksp, null);
                    return;
                case Keys.Add:
                case Keys.Oemplus:
                    btnOp_Click(btnPlu, null);
                    return;
                case Keys.Subtract:
                case Keys.OemMinus:
                    btnOp_Click(btnMin, null);
                    return;
                case Keys.Multiply:
                case Keys.Oem7:
                    btnOp_Click(btnMul, null);
                    return;
                case Keys.Divide:
                case Keys.OemQuestion:
                    btnOp_Click(btnDiv, null);
                    return;
                case Keys.OemOpenBrackets:
                    btnLbrk_Click(btnLbrk, null);
                    return;
                case Keys.OemCloseBrackets:
                    btnRbrk_Click(btnRbrk, null);
                    return;
                case Keys.Space:
                    btnCalc_Click(null, null);
                    return;
            }
        }

        private void btnLbrk_Click(object sender, EventArgs e)
        {
            if (!isStandard)
            {
                if (isFinished)
                {
                    科学计算器ToolStripMenuItem_Click(null, null);
                    isFinished = false;
                }
                labelLbrkPrompt.Visible = true;
                labelLbrkPrompt.Text = Convert.ToString(++singleBrk);
                opState += " ( ";
                labelState.Text = state = viState(opState);
            }
        }

        private void btnRbrk_Click(object sender, EventArgs e)
        {
            if (!isStandard)
            {
                if (singleBrk == 0)
                {
                    return;
                }
                labelLbrkPrompt.Text = Convert.ToString(--singleBrk);
                if (singleBrk == 0)
                {
                    labelLbrkPrompt.Visible = false;
                }
                opState += " ) ";
                labelState.Text = state = viState(opState);
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                return;
            }
            if (isFinished)
            {
                科学计算器ToolStripMenuItem_Click(null, null);
                isFinished = false;
            }
            if (isShift)
            {
                opState += " S";
            }
            else
            {
                opState += " s";
            }
            btnLbrk_Click(null, null);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                return;
            }
            if (isFinished)
            {
                科学计算器ToolStripMenuItem_Click(null, null);
                isFinished = false;
            }
            if (isShift)
            {
                opState += " C";
            }
            else
            {
                opState += " c";
            }
            btnLbrk_Click(null, null);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                return;
            }
            if (isFinished)
            {
                科学计算器ToolStripMenuItem_Click(null, null);
                isFinished = false;
            }
            if (isShift)
            {
                opState += " T";
            }
            else
            {
                opState += " t";
            }
            btnLbrk_Click(null, null);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (isStandard)
            {
                return;
            }
            if (isFinished)
            {
                科学计算器ToolStripMenuItem_Click(null, null);
                isFinished = false;
            }
            if (isShift)
            {
                opState += " L";
            }
            else
            {
                opState += " l";
            }
            btnLbrk_Click(null, null);
        }

        static string InfixToPostfix(string opState)
        {
            if (0 != isOpt(opState[opState.Length - 1]))
            {
                return "错误";
            }
            Stack<char> opt = new Stack<char>();
            char[] infix = opState.ToCharArray();
            StringBuilder postfix = new StringBuilder();
            bool isNum = true;
            for (int i = 0; i < infix.Length; ++i)
            {
                if (infix[i] == ' ')
                {
                    continue;
                }
                else if ('0' <= infix[i] && infix[i] <= '9' || infix[i] == '.' || infix[i] == '-' && '0' <= infix[i + 1] && infix[i + 1] <= '9')
                {
                    if (!isNum)
                    {
                        postfix.Append(' ');
                    }
                    postfix.Append(infix[i]);
                    isNum = true;
                }
                else if ('(' == infix[i])
                {
                    isNum = false;
                    opt.Push('(');
                }
                else if (')' == infix[i])
                {
                    isNum = false;
                    try
                    {
                        while ('(' != opt.Peek())
                        {
                            postfix.Append(' ');
                            postfix.Append(opt.Pop());
                        }
                        opt.Pop();
                    }
                    catch (Exception)
                    {
                        return "错误";
                    }
                }
                else
                {
                    isNum = false;
                    if (opt.Count != 0 && Prior(infix[i], opt.Peek()) > 0)
                    {
                        opt.Push(infix[i]);
                    }
                    else
                    {
                        while (opt.Count != 0 && Prior(infix[i], opt.Peek()) <= 0)
                        {
                            postfix.Append(' ');
                            postfix.Append(opt.Pop());
                        }
                        opt.Push(infix[i]);
                    }
                }
            }
            while (opt.Count != 0)
            {
                postfix.Append(' ');
                postfix.Append(opt.Pop());
            }
            return postfix.ToString();
        }

        static string CalcSent(string opState)
        {
            string postfix;
            try
            {
                if ("错误" == (postfix = InfixToPostfix(opState)))
                {
                    return postfix;
                }
            }
            catch (Exception)
            {
                return "错误";
            }
            Stack<double> optNum = new Stack<double>();
            for (int i = 0; i < postfix.Length; ++i)
            {
                if (postfix[i] == ' ')
                {
                    continue;
                }
                else if (1 == isOpt(postfix[i]))
                {
                    try
                    {
                        switch (postfix[i])
                        {
                            case 's':
                                optNum.Push(Math.Sin(optNum.Pop()));
                                break;
                            case 'S':
                                optNum.Push(Math.Asin(optNum.Pop()));
                                break;
                            case 'c':
                                optNum.Push(Math.Cos(optNum.Pop()));
                                break;
                            case 'C':
                                optNum.Push(Math.Acos(optNum.Pop()));
                                break;
                            case 't':
                                optNum.Push(Math.Tan(optNum.Pop()));
                                break;
                            case 'T':
                                optNum.Push(Math.Atan(optNum.Pop()));
                                break;
                            case 'l':
                                optNum.Push(Math.Log10(optNum.Pop()));
                                break;
                            case 'L':
                                optNum.Push(Math.Log(optNum.Pop()));
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        return "错误";
                    }
                }
                else if (2 == isOpt(postfix[i]) && (i + 1 == postfix.Length || postfix[i + 1] == ' '))
                {
                    double opn1, opn2;
                    try
                    {
                        opn2 = optNum.Pop();
                        opn1 = optNum.Pop();
                    }
                    catch (Exception)
                    {
                        return "错误";
                    }
                    if (postfix[i] == 'q')
                    {
                        optNum.Push(Math.Pow(opn2, 1D / opn1));
                    }
                    else if (postfix[i] == '^')
                    {
                        optNum.Push(Math.Pow(opn1, opn2));
                    }
                    else
                    {
                        optNum.Push(CalcStandard(opn1, opn2, postfix[i]));
                    }
                }
                else
                {
                    StringBuilder singleNum = new StringBuilder();
                    while (i < postfix.Length && ('0' <= postfix[i] && postfix[i] <= '9' || postfix[i] == '.' || postfix[i] == '-' && '0' <= postfix[i + 1] && postfix[i + 1] <= '9'))
                    {
                        singleNum.Append(postfix[i++]);
                    }
                    try
                    {
                        optNum.Push(Convert.ToDouble(singleNum.ToString()));
                    }
                    catch (Exception)
                    {
                        return "错误";
                    }
                    --i;
                }
            }
            if (optNum.Count != 1)
            {
                return "错误";
            }
            else
            {
                return Convert.ToString(optNum.Pop());
            }


        }

        // 返回运算符目数
        static int isOpt(char c)
        {
            if (c == 's' || c == 'S' || c == 'c' || c == 'C' || c == 't' || c == 'T' || c == 'l' || c == 'L' || c == 'l')
            {
                return 1;
            }
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == 'q' || c == '^')
            {
                return 2;
            }
            return 0;
        } 

        static int Prior(char opt1, char opt2)
        {
            return Priority(opt1) - Priority(opt2);
        }
       
        static int Priority(char opt)
        {
            switch (opt)
            {
                case '(':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case 'q':
                case '^':
                    return 3;
                default:
                    return 4;
            }
        }

        private void 关于本计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t------------------HELP------------------\n\n\n\n\t                ４０４！\n\n\t                NOT FOUND\n\n\t      Sorry, but the help file is lost...\n\n\n\n\n\n\n\t\t           (Zhishi lande xie eryi.)\n\t------------------------------------------\n\n\n\t                   任皓天[Haotian_Ren@outlook.com]\n\t\t\t\t2016年11月9日");
        }

        private void labelState_TextChanged(object sender, EventArgs e)
        {
            if (!isStandard)
            {
                richTextBoxDisplay.Text = labelState.Text + "\n\n" + labelResult.Text;
                if (labelState.Width > 305)
                {
                    labelState_MouseHover(null, null);
                }
                else
                {
                    richTextBoxDisplay_MouseLeave(null, null);
                }
            }
        }
    }
}

