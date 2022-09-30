using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D  body;
    [SerializeField]
    float speed = .125f, superSpeed = 50f;

    [SerializeField]
    float horizontal, vertical;
    
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D >();
        //body.AddForce(transform.right * superSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //body.AddForce(transform.right * speed);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        direction.x = horizontal * speed;
        direction.y = vertical * speed;

        body.AddForce(direction, ForceMode2D.Impulse);
    }
}
