using UnityEngine;
using TMPro;

public class score1 : MonoBehaviour
{
    public TMP_Text scoreText;
    public float score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
