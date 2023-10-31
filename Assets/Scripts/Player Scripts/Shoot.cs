using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootcontroller;


    Movement input;

    // Start is called before the first frame update
    void Start()
    {
        input = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Shooting();
        }
    }

    private void Shooting()
    {
        Instantiate(bullet, shootcontroller);
    }
}
