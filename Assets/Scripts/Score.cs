using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D()
    {
        score++;
    }
}
