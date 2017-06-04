using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSomething : MonoBehaviour
{
    public int kind;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            switch (kind)
            {
                case 0:
                    Debug.Log("Nic");
                    Destroy(col.gameObject);
                    break;

                case 1:

                    break;


            }
        }
    }


}
