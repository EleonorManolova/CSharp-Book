using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202.X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.Read();
            decimal sum = 0.00m;
            var sumOld = 0.00m;
            int expressionOperator = '+';
            decimal innerSum = 0;

            while (expression != '=')
            {
                
                if (expression == '(')
                {
                    decimal innerResult = 0;
                    int innerOperator = '+';
                   // innerSum = 0;
                    while (true)
                    {
                        if (expression == ')')
                        {
                            break;
                        }
                        if (0 <= expression - '0' && expression - '0' <= 9)
                        {

                            switch (innerOperator)
                            {
                                case '+':
                                    innerSum += expression - '0';
                                    break;
                                case '-':
                                    innerSum -= expression - '0';
                                    break;
                                case '*':
                                    innerSum *= expression - '0';
                                    break;
                                case '/':
                                    innerSum /= expression - '0';
                                    break;
                                default:
                                    break;
                            }

                        }
                        else if (expression == '+' || expression == '-' || expression == '*' || expression == '/')
                        {
                            innerOperator = expression;
                        }
                        expression = Console.Read();
                    }
                }
                
                else if (0 <= expression - '0' && expression - '0' <= 9)
                {
                    switch (expressionOperator)
                    {
                        case '+':
                            sum += expression - '0';
                            break;
                        case '-':
                            sum -= expression - '0';
                            break;
                        case '*':
                            sum *= expression - '0';
                            break;
                        case '/':
                            sum /= expression - '0';
                            break;
                        default:
                            break;
                    }
                }
                else if (expression == '+' || expression == '-' || expression == '*' || expression == '/')
                {
                    expressionOperator = expression;
                }
                if (innerSum != 0)
                {
                    switch (expressionOperator)
                    {
                        case '+':
                            sum += innerSum;
                            break;
                        case '-':
                            sum -= innerSum;
                            break;
                        case '*':
                            sum *= innerSum;
                            break;
                        case '/':
                            sum /= innerSum;
                            break;
                        default:
                            break;
                    }
                    innerSum = 0;
                }

                expression = Console.Read();
            }
            Console.WriteLine($"{sum:0.00}");

        }
    }
}
