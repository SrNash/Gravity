using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    [HideInInspector]
    PlayerController player;
    [SerializeField]
    FuelBar fuelBar;
    [SerializeField]
    float fuelAmount = 5f;

    [Header("PS Prefab")]
    [SerializeField]
    GameObject prefab;

    void Update()
    {

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {            
            if (player.currentFuel >= player._maxFuel)
            {
                player.currentFuel = player._maxFuel;
            }else if (player.currentFuel <= player._maxFuel)
            {
                Debug.Log("SUMA COMBUSTIBLE");
                player.currentFuel += fuelAmount;
                Destroy(this);
            }
        }
    }
}
