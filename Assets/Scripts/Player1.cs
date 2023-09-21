
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float racketSpeed;

    private Rigidbody2D _rb;
    private Vector2 _racketDirection;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");

        _racketDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        _rb.velocity = _racketDirection * racketSpeed;
    }
}
