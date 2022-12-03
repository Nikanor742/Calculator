using System;
using System.Collections.Generic;

public class AdditionCalculator : ICalculator
{
    public string Calculate(string _inputData)
    {
        if (_inputData != null)
        {
            char[] input = _inputData.ToCharArray();

            List<char> leftOperand = new List<char>();
            List<char> rightOperand = new List<char>();

            bool leftOperandFinded = false;
            bool errorFinded = false;
            bool operatoFinded = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '+')
                {
                    int val;
                    if (int.TryParse(input[i].ToString(), out val))
                    {
                        if (!leftOperandFinded)
                            leftOperand.Add(input[i]);
                        else
                            rightOperand.Add(input[i]);
                    }
                    else
                    {
                        errorFinded = true;
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        errorFinded = true;
                        break;
                    }
                    else
                    {
                        if (!leftOperandFinded)
                        {
                            operatoFinded = true;
                            leftOperandFinded = true;
                        }
                        else
                        {
                            errorFinded = true;
                            break;
                        }
                    }
                }
            }
            if (!errorFinded && operatoFinded)
            {
                int leftOperan = Int32.Parse(new string(leftOperand.ToArray()));
                int rightOperan = Int32.Parse(new string(rightOperand.ToArray()));

                return (leftOperan + rightOperan).ToString();
            }
            else
            {
                return "Error";
            }
        }
        else
        {
            return "Error";
        }
    }
}
