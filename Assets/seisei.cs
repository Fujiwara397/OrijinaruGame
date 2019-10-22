using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seisei : MonoBehaviour
{
    public GameObject[] DoubutuT;
    public GameObject dropanimal;
    public float timeOut;
    public float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        timeOut = 5.0f;

    }

    // Update is called once per frame
    void Update()
    {
        timeOut = 5.0f;
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeOut)
        {
            dropanimal = DoubutuT[Random.Range(0, DoubutuT.Length)];
            Instantiate(dropanimal, transform.position, transform.rotation);
            timeElapsed = 0.0f;
        }

    }
}
