using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CalculatorView : MonoBehaviour
{
    private TMP_InputField _inputField;
    private Button _resultButton;

    public TMP_InputField InputField => _inputField;
    public Button ResultButton => _resultButton;


    public void Init()
    {
        _inputField = GetComponentInChildren<TMP_InputField>();
        _resultButton = GetComponentInChildren<Button>();
    }

    public void ShowResult(string result)
    {
        _inputField.text = result;
    }
}
