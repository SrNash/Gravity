using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D  body;
    [SerializeField]
    float speed = .125f, superSpeed = 50f;  //Variables de velocidad

    float horizontal, vertical;
    public float _horizontal, _vertical;    //Variables de encapsulamiento de los ejes H y V
    
    public Vector2 direction;   //Variable de control de dirección de movimiento

    [Header("PlayerSprite")]
    [SerializeField]    // Variable para controlar la dirección a la que mira el SPRITE
    GameObject playerSprite;

    [Header("Fuel")]
    public float fuel;  //Variable de combustible por defecto
    [SerializeField]
    protected float maxFuel;    
    public float _maxFuel;  //Variable de encapsulamiento
    public float currentFuel;   //Variable de cantidad actual de combustible
    float  fuelLess = 1f;   //Variable de cantidad de perdida de combustible
    float timerFuel;    //Variable de tiempo para controlar con mayor precisión la perdida de combustible

    [Header("KeyCodes")]
    public KeyCode jetPackKey;

    [Header("Control")]
    public bool isPlaying = false;  //Variable de control de partida

    [Header("Canvas")]
    [SerializeField]
    GameObject deadCanvas;

    [Header("Otros Componentes")]
    public FuelBar fuelBar;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
        body = GetComponent<Rigidbody2D >();
        currentFuel = fuel;
        maxFuel = fuel;
        _maxFuel = maxFuel;
        //body.AddForce(transform.right * superSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //body.AddForce(transform.right * speed);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        if (horizontal <= -.5f)
        {
            playerSprite.transform.localScale = new Vector3(-.5f, .5f, 0);
        }else if (horizontal >= .5f)
        {
            playerSprite.transform.localScale = new Vector3(.5f, .5f, 0);
        }
        _horizontal = horizontal;
        _vertical = vertical;

        
        timerFuel += .125f;
    }

    void FixedUpdate()
    {
        direction.x = horizontal * speed;
        direction.y = vertical * speed;

        body.AddForce(direction, ForceMode2D.Impulse);
    }

    void LateUpdate()
    {
        if (timerFuel >= 5f)
        {
            currentFuel -= 1f;
            timerFuel = 0f;
        }
        
    }

    private void Dead()
    {
        deadCanvas.SetActive(true);
    }
}
