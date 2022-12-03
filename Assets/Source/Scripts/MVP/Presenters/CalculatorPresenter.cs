
using UnityEngine;

public class CalculatorPresenter
{
    private CalculatorView _calculatorView;
    private CalculatorModel _calculatorModel;

    public CalculatorPresenter(CalculatorView view, CalculatorModel model)
    {
        _calculatorView = view;
        _calculatorModel = model;
    }

    public void Enable()
    {
        _calculatorModel.OnCalculate += Calculate;

        _calculatorView.Init();
        _calculatorView.ResultButton.onClick.AddListener(_calculatorModel.Calculate);
        _calculatorView.InputField.onValueChanged.AddListener(_calculatorModel.SetInputData);

        if (PlayerPrefs.GetString("Result") != "Error")
            _calculatorView.ShowResult(PlayerPrefs.GetString("Result", ""));
    }

    private void Calculate(string result)
    {
        _calculatorView.ShowResult(result);
    }

    public void Disable()
    {
        _calculatorModel.OnCalculate -= Calculate;
        _calculatorView.ResultButton.onClick.RemoveListener(_calculatorModel.Calculate);
        _calculatorView.InputField.onValueChanged.RemoveListener(_calculatorModel.SetInputData);
    }
}
