using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D  body;
    [SerializeField]
    float speed = .125f, superSpeed = 50f;

    float horizontal, vertical;
    
    public Vector2 direction;

    [Header("Salud, Oxígeno y Combustible")]
    [SerializeField]
    public float health;
    public float oxygen;
    public float fuel;
    [SerializeField]
    [Tooltip("Esta es la cantidad máx. de Salud")]
    protected float maxHealth;
    public float _maxHealth;
    [SerializeField]
    [Tooltip("Esta es la cantidad máx. de Salud")]
    protected float maxOxygen;
    public float _maxOxygen;
    [SerializeField]
    [Tooltip("Esta es la cantidad máx. de Salud")]
    protected float maxFuel;
    public float _maxFuel;

    [Header("Canvas")]
    [SerializeField]
    GameObject deadCanvas;
    [SerializeField]
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D >();
        maxHealth = health;
        maxOxygen = oxygen;
        maxFuel = fuel;
        //body.AddForce(transform.right * superSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //body.AddForce(transform.right * speed);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if(health <= 0f)
        {
            Dead();
            health = 0;
        }
    }

    void FixedUpdate()
    {
        direction.x = horizontal * speed;
        direction.y = vertical * speed;

        body.AddForce(direction, ForceMode2D.Impulse);
    }
    private void Dead()
    {
        deadCanvas.SetActive(true);
    }
}
