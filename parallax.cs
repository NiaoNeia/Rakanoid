using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    [SerializeField]
    private float _scrollSpeed=1f;
    private float _Range=5.5f;
    private Vector3 _startPosition;
    private float _newPosition;
	private void Start ()
    {
        _startPosition = transform.position;
	}
	private void Update ()
    {
        _newPosition = Mathf.Repeat(Time.time * _scrollSpeed, _Range);
        transform.position = _startPosition + Vector3.left * _newPosition;
	}
}
