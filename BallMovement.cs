using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 150f;
    private bool _keyShoot;
    private Rigidbody2D _rigidBody;
    private bool _BallIsActive;
    private Vector3 _BallPosition;
    public delegate void DelegateHPManager();
    private GameObject Player;
    public event DelegateHPManager PlayerLivesControl;
	private void Start ()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _BallIsActive = false;
        _BallPosition = transform.position;
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerLivesControl +=Player.GetComponent<PlayerLives>().PlayerLive;
        PlayerLivesControl += Player.GetComponent<PlayerMove>().ResetPosition;

    }
	private void Update ()
    {
     if(!_BallIsActive)
        {
            transform.position = new Vector3(Player.transform.position.x, -3, 0);
        }
        _keyShoot = Input.GetKeyDown(KeyCode.Space);
        if (_keyShoot)
        {
            if (!_BallIsActive)
            {
;               _rigidBody.bodyType = RigidbodyType2D.Dynamic;
                _rigidBody.AddForce(new Vector2(1f, 3f) * _speed);
                _BallIsActive = !_BallIsActive;
            }
        }
        if(transform.position.y<-16f)
        {
            PlayerLivesControl();
            _BallIsActive = !_BallIsActive;
            transform.position = _BallPosition;
            _rigidBody.velocity = (new Vector2(0f, 0f));
            _rigidBody.bodyType = RigidbodyType2D.Kinematic;
        }
	}
}
