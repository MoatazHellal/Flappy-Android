using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayScore : MonoBehaviour
{
    public TextMeshProUGUI tmpro;
    // Start is called before the first frame update
    void Start()
    {
        Score.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tmpro.text = "Score :"+ Score.score +"/20" ;
    }
}
