using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

   // asa se misca cubul fata ,spate,stanga ,dreapta
    void FixedUpdate()
    {
        // miscare in fata
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if(Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
