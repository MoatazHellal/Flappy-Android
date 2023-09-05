using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    [SerializeField]
    float velocity ;
    Rigidbody2D rb;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
            FindObjectOfType<AudioManager>().Play("Jump");
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
    }
}
