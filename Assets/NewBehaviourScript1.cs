using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * 0.5f;

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WallTag")
        {
            if (Random.Range(1, 10) < 6)
            {
                this.transform.Rotate(0, 120, 0);
            }
            else
            {
                this.transform.Rotate(0, -120, 0);

            }
        }




        
    }
} 
