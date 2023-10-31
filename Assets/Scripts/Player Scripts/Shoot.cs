using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootcontroller;
    [SerializeField] private int munition;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shooting();
        }
    }

    private void Shooting()
    {
        Instantiate(bullet,shootcontroller.position,shootcontroller.rotation);
    }
}
