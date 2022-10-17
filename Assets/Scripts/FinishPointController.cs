using UnityEngine;

public class FinishPointController : MonoBehaviour
{
    private float _transformForward;

    private void Start()
    {
        _transformForward = transform.position.z;        
    }
    private void Update()
    {
        _transformForward = InputFieldController._distance;
        transform.position = new Vector3(0, 0, _transformForward);
    }
}
