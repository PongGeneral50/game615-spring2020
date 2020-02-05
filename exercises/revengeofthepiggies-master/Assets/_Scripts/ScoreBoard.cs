using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    const int STRUCTUE_HIT_POINT = 1;
    const int PIGGY_HIT_STRUCTUE_POINT = 5;
    private int scoreValue = 0;

    public int getScore()
    {
        return scoreValue;
    }
    public void StructureColStructure()
    {
        scoreValue = scoreValue + STRUCTUE_HIT_POINT;
    }
    public void PiggyColStructure()
    {
        scoreValue = scoreValue + PIGGY_HIT_STRUCTUE_POINT;
    }
}