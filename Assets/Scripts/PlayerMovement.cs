using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float upForce, downForce;

    private Rigidbody2D rb2d;
    private bool OnGround = false, canDrop = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if (OnGround)
            {
                rb2d.AddForce(new Vector2(0, upForce), ForceMode2D.Impulse);
                canDrop = true;
            }
            else
            {
                if (canDrop)
                {
                    rb2d.AddForce(new Vector2(0, -downForce), ForceMode2D.Impulse);
                    canDrop = false;
                }
            }
        }
    }


    void OnCollisionStay2D(Collision2D collision)
    {
        OnGround = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        OnGround = false;
    }
}
