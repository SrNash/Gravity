using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
     [SerializeField]
    protected PlayerController player;
    [SerializeField]
    Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<CapsuleCollider2D>();

        if (col == null)
        {
            col = GetComponent<CapsuleCollider2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(player.health);
            player.health -= 1f;
        }
    }
}
