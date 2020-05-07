using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float acceleration;

    public GameObject player;
    private Rigidbody rgPlayer;
    private Transform trPlayer;

    void Start()
    {
        trPlayer = player.GetComponent<Transform>();
        rgPlayer = player.GetComponent<Rigidbody>();

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {

            rgPlayer.AddForce(trPlayer.right * acceleration, ForceMode.Force);

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {

            rgPlayer.AddForce(rgPlayer.velocity * -0.5f, ForceMode.Impulse);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rgPlayer.AddForce(trPlayer.right * -acceleration, ForceMode.Force);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            rgPlayer.AddForce(rgPlayer.velocity * -0.5f, ForceMode.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            rgPlayer.AddForce(trPlayer.up * acceleration, ForceMode.Impulse);

        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {

            rgPlayer.AddForce(rgPlayer.velocity * -0.5f, ForceMode.Impulse);

        }

    }

    private void OnCollisionStay(Collider other)
    {

        if (other.gameObject.tag == "Terrain")
        { 
        
            

        }

    }

}
