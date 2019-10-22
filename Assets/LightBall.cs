using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * 0.4f;

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
        if (collision.gameObject.tag == "PlayerTag")
        {
            Destroy(this.gameObject);
        }

    }
}