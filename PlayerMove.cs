using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _PlayerSpeed=1f;
    private Vector3 _StartPos;
    private void Start()
    {
        _StartPos = transform.position;
    }
    private void Update ()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0)*Time.deltaTime*_PlayerSpeed);  
	}
    public void ResetPosition ()
    {
        transform.position = _StartPos;
    }
}
