using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerController playerController;
    // Start is called before the first frame update
    private void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            //Kill 
            playerController.Die();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
