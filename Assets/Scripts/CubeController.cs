using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Transform _finishTransform;
    private float _speed;

    private void Start()
    {
        _finishTransform = GameObject.FindGameObjectWithTag("Finish").GetComponent<Transform>();
    }
    private void Update()
    {
        _speed = InputFieldController._speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == GameObject.FindGameObjectWithTag("Finish"))
            Destroy(gameObject);
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _finishTransform.position, _speed * Time.deltaTime);        
    }

}
