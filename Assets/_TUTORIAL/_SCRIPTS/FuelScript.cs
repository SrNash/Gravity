using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    [Header("Player")]
    [SerializeField]
    PlayerController player;
    
    [Header("FuelBar")]
    [SerializeField]
    FuelBar fuelBar;
    [SerializeField]
    float fuelAmount = 10f;

    [Header("AudioSource")]
    [SerializeField]
    AudioSource asFuel;


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
                asFuel.Play();
                Destroy(this.gameObject, .2f);
            }
        }
    }
}
