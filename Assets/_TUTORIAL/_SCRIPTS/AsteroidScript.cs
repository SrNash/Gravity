using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    [Header("Self")]
    [SerializeField]
    Transform selfTrans;
    [Header("Componentes")]
    [HideInInspector]
    protected PlayerController player;
    [SerializeField]
    Collider2D col;
    [Header("Childs")]
    [SerializeField]
    GameObject[] goChilds;

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
        /*for (int i = 0; i < selfTrans.childCount; i++)
        {
            goChilds[i].transform.Rotate(90f,0f,0f);
        }*/
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            /*Debug.Log(player.health);
            player.health -= 1f;*/
        }
    }
}
