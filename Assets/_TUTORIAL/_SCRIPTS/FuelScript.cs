using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    [SerializeField]
    PlayerController player;
    [SerializeField]
    FuelBar fuelBar;
    [SerializeField]
    float fuelAmount = 10f;


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
                player.TakeFuel(this.gameObject.transform.position);
                Destroy(this.gameObject);
            }
        }
    }
}
