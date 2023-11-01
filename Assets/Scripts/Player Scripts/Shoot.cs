using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootcontroller;
    [SerializeField] private int munition = 20;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(munition > 0)
            {
                Shooting();
            }
        }
    }

    private void Shooting()
    {
        Instantiate(bullet,shootcontroller.position,shootcontroller.rotation);
        munition--;

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ammo"))
        {
            munition = munition + 20;
            Destroy(collision.gameObject);
        }
    }
}
