using UnityEngine;

public class CalculatorController : MonoBehaviour
{
    private CalculatorPresenter _calculatorPresenter;
    private CalculatorModel _calculatorModel;

    public void Start()
    {
        var calculatorView = FindObjectOfType<CalculatorView>();

        _calculatorModel = new CalculatorModel(new AdditionCalculator());
        _calculatorPresenter = new CalculatorPresenter(calculatorView, _calculatorModel);

        _calculatorPresenter.Enable();
    }

    private void OnDestroy()
    {
        _calculatorPresenter.Disable();
    }
}
