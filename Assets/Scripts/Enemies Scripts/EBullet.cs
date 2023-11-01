using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EBullet : MonoBehaviour
{

    GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 movDir = (target.transform.position - transform.position).normalized * speed;
        rb2d.velocity = new Vector2 (movDir.x, movDir.y);
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
   
}
