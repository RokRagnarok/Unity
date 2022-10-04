using UnityEngine;

public class Player_Movement : MonoBehaviour
{

   public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;
    // Start is called before the first frame update
   private void FixedUpdate()
    {
        Vector3 forewardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forewardMove + horizontalMove );
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

}
