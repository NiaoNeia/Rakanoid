using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _blocks;
    private GameObject _cube;
	private void Start ()
    {
        StartCoroutine(Spawn());   		
	}
    private IEnumerator Spawn()
    {
        var waiter = new WaitForSeconds(0.1f);
        for (int i = 0; i < 10; i++)
        {            
            _cube = Instantiate(_blocks[Random.Range(0,3)], new Vector2(-5.5f + i + 0.1f * i, 1), Quaternion.identity);
            yield return waiter;
        }
        for (int i = 0; i < 10; i++)
        {
            if (i % 3 == 0) continue;
            _cube = Instantiate(_blocks[Random.Range(0, 3)], new Vector2(-5.5f + i + 0.1f * i, 2.1f), Quaternion.identity);
            yield return waiter;

        }
        for (int i = 0; i < 10; i++)
        {
            _cube = Instantiate(_blocks[Random.Range(0, 3)], new Vector2(-5.5f + i + 0.1f * i, 3.2f), Quaternion.identity);
            yield return waiter;
        }
    }
}
