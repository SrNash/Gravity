using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    [Header("Colliders")]
    [SerializeField]
    Collider2D colRocket_1;
    [SerializeField]
    Collider2D  colRocket_2;
    [Header("Hit Control")]
    [SerializeField]
    float timer;
    [SerializeField]
    bool isHitting = false;
    [Header("Otros Como.")]
    [SerializeField]
    protected PlayerController player;
    void Start()
    {
        colRocket_1 = GetComponent<CapsuleCollider2D>();
        colRocket_2 = GetComponent<BoxCollider2D>();

        if (colRocket_1 == null)
        {
            colRocket_1 = GetComponent<CapsuleCollider2D>();
        }

        if (colRocket_2 == null)
        {
            colRocket_2 = GetComponent<BoxCollider2D>();
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
            colRocket_2.isTrigger = true;
        }

        if (timer >= 15f)
        {
            isHitting = false;
            colRocket_1.isTrigger = false;
            colRocket_2.isTrigger = false;
            timer = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isHitting = true;
           /*Debug.Log(player.health);
            player.health -= 1f;*/
            
        }
    }
}
