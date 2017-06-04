using UnityEngine;

public class SecondPlayerMovment : MonoBehaviour {
    public float speed = 2;
    public Rigidbody2D player;
    public bool isAbleToMove = false;
    float transformX;
    float transformY;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isAbleToMove == true)
        {

            SetLeft();
            SetUp();


            transformX *= speed * 2;
            transformY *= speed * 2;

            if (transformX != 0 || transformY != 0)
            {
                player.GetComponent<Animator>().SetFloat("speed", 2);
            }

            if (transformX == 0 && transformY == 0)
            {
                player.GetComponent<Animator>().SetFloat("speed", 0);
            }
            player.velocity = new Vector2(transformX, transformY);
        }
    }



    private void SetUp()
    {
        if (Input.GetKey(KeyCode.S))
        {

            transformY = -1; //Input.GetAxis("Horizontal");

                
            return;

        }
        if (Input.GetKey(KeyCode.W))
        {

            transformY = 1; //Input.GetAxis("Horizontal");
            return;
        }

        else
        {

            transformY = 0; //Input.GetAxis("Horizontal");
            return;
        }
    }



    private void SetLeft()
    {

        if (Input.GetKey(KeyCode.A))
        {

            transformX = -1; //Input.GetAxis("Horizontal");
            return;

        }


        if (Input.GetKey(KeyCode.D))
        {

            transformX = 1; //Input.GetAxis("Horizontal");
            return;
        }

        else
        {
            transformX = 0; //Input.GetAxis("Horizontal");
            return;
        }
    }

    public void SetAbletoMove(bool stan)
    {
        isAbleToMove = stan;
    }
}
