using UnityEngine;
using System;

public class crate : MonoBehaviour
{
    public score1 score12;
    bool hasIncreased = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score12 = GameObject.Find("Text").GetComponent<score1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasIncreased && Math.Abs(transform.position.x - (-30)) > 2)
        {
            score12.score++;
            hasIncreased = true;
        } 
    }
}
