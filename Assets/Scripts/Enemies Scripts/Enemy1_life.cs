using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_life : MonoBehaviour
{
    [SerializeField] private int life;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet1"))
        {
            life--;
            Destroy(collision.gameObject);

            if(life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
