using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [Header("Player")] 
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb2d;

    [SerializeField]private float speed2;
    [SerializeField]public Rigidbody2D rb;
    [SerializeField]private Transform shootcontroller;
    [SerializeField]private GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    

    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        rb2d.velocity = new Vector2 (moveX * speed, moveY * speed);
    }

    private void Shoot()
    {
        
    }


}
