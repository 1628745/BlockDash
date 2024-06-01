using UnityEngine;

public class Player_Movement : MonoBehaviour
{

	public Rigidbody rb;

	//float is used for decimal numbers, there is also int for whole numbers, bool for true/false, and string for text
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") || (Input.touchCount > 0 && Input.touches[0].position.x > Screen.width / 2))
        {
        	//Only executed if condition is met
        	rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") || (Input.touchCount > 0 && Input.touches[0].position.x < Screen.width / 2))
        {
        	//Only executed if condition is met
        	rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
