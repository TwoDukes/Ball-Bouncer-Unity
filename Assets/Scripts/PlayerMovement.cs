using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private bool OnGround = true;

    void OnCollisionStay2D(Collision2D collision)
    {
        OnGround = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
         OnGround = false;
    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)){
            if (OnGround)
            {
                rb2d.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            }
            else
            {
                rb2d.AddForce(new Vector2(0, -20), ForceMode2D.Impulse);
            }
        }

    }
}
