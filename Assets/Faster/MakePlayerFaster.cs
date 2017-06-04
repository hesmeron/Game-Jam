using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerFaster : MonoBehaviour {
    public PlayerMovment pm;
    public PointsCounter pc;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            if (pc.points > 0)
            {

                pc.points--;
                pm.speed = 4;
                StartCoroutine(MyC());

            }
        }
    }

    IEnumerator MyC()
    {
        yield return new WaitForSeconds(2f);
        pm.speed = 2;
    }
}
