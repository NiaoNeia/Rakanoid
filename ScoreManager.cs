using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float _Scores = 0f;
    public void SumScores(float scorepoints)
    {
        _Scores = _Scores + scorepoints;
        Debug.Log(_Scores);
    }
}
