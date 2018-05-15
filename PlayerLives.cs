using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour {
    private float _PlayerHP=3;
    public void PlayerLive()
    {
            _PlayerHP--;
            Debug.Log(_PlayerHP);
    }
}
