using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WaferBondingForceMeasureSystem.Models.Algorithms;

namespace WaferBondingForceMeasureSystem.ApplicationModule.NumCalculator
{
    /// <summary>
    /// 功能描述    ：NumCalcuService
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/23 15:01:30 
    /// </summary>
    class NumCalcuService
    {
        private static int Priority(char c)
        {
            if (c == '*' || c == '/')
            {
                return 1;
            }
            else if (c == '+' || c == '-')
            {
                return 0;
            }
            else return -1;
        }
        private static bool IsOper(char c)
        {
            if (c == '(' || c == ')' || c == '*' || c == '/' || c == '+' || c == '-')
            {
                return true;
            }
            else return false;
        }
        private static float OperResult(float a, float b, char c)
        {
            if (c == '*')
            {
                return a * b;
            }
            else if (c == '/')
            {
                return b / a;
            }
            else if (c == '+')
            {
                return a + b;
            }
            else if (c == '-')
            {
                return b - a;
            }
            else
            {
                return 0;
            }
        }

        public float BondStrength(BondingForceModel bondingForceModel)
        {
            int depth = bondingForceModel.SlottingKnifeDepth;
            Stack<float> Num = new Stack<float>(24);
            Stack<char> Operator = new Stack<char>(25);
            //string str = "(2*(2+3)+4)*5";
            //char[] cc = new char[] { '(', (char)2, '*', '(', (char)2, '+',(char)3, ')', '+', (char)4 ,')', '*', (char)5 };
            char[] bs = new char[] { (char)3, '*', (char)depth };
            for (int i = 0; i < bs.Length; i++)
            {
                if (Num.Count == 0 && Operator.Count == 0)
                {
                    if (IsOper(bs[i]))
                    {
                        Operator.Push(bs[i]);
                    }
                    else
                    {
                        Num.Push(bs[i]);
                    }
                }
                else
                {
                    if (IsOper(bs[i]))
                    {
                        if (Operator.Count == 0)
                        {
                            Operator.Push(bs[i]);
                        }
                        else
                        {
                            if (bs[i] == '(')
                            {
                                Operator.Push(bs[i]);
                            }
                            else if (bs[i] == ')')
                            {
                                while (Operator.Peek() != '(')
                                {
                                    float n1 = Num.Pop();
                                    float n2 = Num.Pop();
                                    float n = OperResult(n1, n2, Operator.Pop());
                                    Num.Push(n);
                                }
                                Operator.Pop();
                            }
                            else
                           if (Priority(bs[i]) <= Priority(Operator.Peek()))
                            {
                                float n1 = Num.Pop();
                                float n2 = Num.Pop();
                                float n = OperResult(n1, n2, Operator.Pop());
                                Operator.Push(bs[i]);
                                Num.Push(n);
                            }
                            else
                            {
                                Operator.Push(bs[i]);
                            }
                        }
                    }
                    else
                    {
                        Num.Push(bs[i]);
                    }
                }
                if (i == bs.Length - 1)
                {
                    while (Operator.Count != 0)
                    {
                        char o = Operator.Pop();
                        float n1 = Num.Pop();
                        float n2 = Num.Pop();
                        float n = OperResult(n1, n2, o);
                        Num.Push(n);
                    }
                }
            }
            return Num.Pop();
        }
    }
}
