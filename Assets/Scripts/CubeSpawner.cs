using System.Collections;
using UnityEngine;



public class CubeSpawner : MonoBehaviour
{
    
    [SerializeField] private GameObject _cubePrefab;
    private float _time;


    private void Start()
    {
        
        StartCoroutine(Spawner());
    }

    private void Update()
    {
        _time = InputFieldController._time;
    }

    IEnumerator Spawner() 
    {
        while (true)
        {
            yield return new WaitForSeconds(_time);
            SpawnCube();
        }
    }
    private void SpawnCube() 
    {
        Instantiate(_cubePrefab, transform);
    }
    
}
