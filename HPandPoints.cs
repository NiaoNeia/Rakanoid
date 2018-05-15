using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPandPoints : MonoBehaviour
{
    public float HP;
    public float Points;
    private float _Damage=0f;
    private GameObject Camera;
    public delegate void DelegateScoreManager(float points);
    public event DelegateScoreManager SumScore;
    void Start()
    {
        if(CompareTag("50points"))
        {
            HP = 3f;
            Points = 50f;
        }
        if (CompareTag("20points"))
        {
            HP = 2f;
            Points = 20f;
        }
        if (CompareTag("10points"))
        {
            HP = 1f;
            Points = 10f;
        }
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        SumScore += Camera.GetComponent<ScoreManager>().SumScores;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag=="Ball")
        {   
            _Damage ++;
            if (_Damage == HP)
            {
                SumScore(Points);
                Destroy(gameObject);
            }
        }
    }
}
