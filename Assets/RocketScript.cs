using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    [SerializeField]
    protected PlayerController player;
    [SerializeField]
    Collider2D colRocket_1, colRocket_2;
    // Start is called before the first frame update
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
