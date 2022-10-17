using UnityEngine;
using UnityEngine.UIElements;



public class InputFieldController : MonoBehaviour
{
    public static TextField _timeTextField { get; private set; }
    public static TextField _speedTextField { get; private set; }
    public static TextField _distanceTextField { get; private set; }

    public static float _time { get; private set; }
    public static float _speed { get; private set; }
    public static float _distance { get; private set; }

    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        _timeTextField = root.Q<TextField>("TimeTextField");
        _speedTextField = root.Q<TextField>("SpeedTextField");
        _distanceTextField = root.Q<TextField>("DistanceTextField");
    }

    private void Update()
    {
        _time = Exceptions.TryConvertSingle(_timeTextField.text);
        _speed = Exceptions.TryConvertSingle(_speedTextField.text);
        _distance = Exceptions.TryConvertSingle(_distanceTextField.text);
    }
}
