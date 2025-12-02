using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public bool IsInvulnerable;

    [SerializeField] public int MoveSpeed;

    //Public Fields
    private float moveSpeed = 5f;
    private float jumpForce = 10f;

    private Rigidbody2D rb;

    public void SetMoveSpeed(float newSpeed)
    {
        newSpeed = MoveSpeed;
    }

    public void SetInvulnerability(bool IsEnabled)        
    {
        if (!IsEnabled)
        {
            Debug.Log("Player is Immune to All Damage.");
        }
        else
        {
            Debug.Log("Player is NOT immune.");
        }
    }

    public void OnTriggerEnter2D()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}
