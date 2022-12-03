using System;
using UnityEngine;

public class CalculatorModel
{
    public event Action<string> OnCalculate;

    private ICalculator _calculator;
    private string _inputData;
    private string _result;

    public CalculatorModel(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public void SetInputData(string inputData)
    {
        _inputData = inputData;
        PlayerPrefs.SetString("Result", _inputData);
    }

    public void Calculate()
    {
        _result = _calculator.Calculate(_inputData);
        
        OnCalculate?.Invoke(_result);
    }
}
