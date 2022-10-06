using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    [Header("Colliders")]   //Variables del collider
    [SerializeField]
    Collider2D colRocket_1;
    [SerializeField]
    float dmg = 5f;
    [Header("Hit Control")]
    [SerializeField]
    float timer;    //Variable de temporizador de impacto
    [SerializeField]
    bool isHitting = false; //boolean de cuando el Player es golpeado
    [Header("Otros Como.")]
    [SerializeField]
    protected PlayerController player;
    void Start()
    {
        colRocket_1 = GetComponent<CapsuleCollider2D>();

        if (colRocket_1 == null)
        {
            colRocket_1 = GetComponent<CapsuleCollider2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        /// Comprobamos si hemos colicionado con el Player
        /// si es así, comenzará un timer para que no siga 
        /// haciendo daño al Player

        if (isHitting)
        {
            timer += Time.deltaTime;
            colRocket_1.isTrigger = true;
        }

        if (timer >= 15f)
        {
            isHitting = false;
            colRocket_1.isTrigger = false;
            timer = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isHitting = true;
           Debug.Log(player.currentFuel);
            player.currentFuel -= dmg;
            
        }
    }
}
