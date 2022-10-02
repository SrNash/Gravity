using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    public Slider oxygenBar;
    [SerializeField]
    PlayerController playerOxygen; 
    [SerializeField]
    float oxygen;
    [SerializeField]
    float  oxygenLess;
    // Start is called before the first frame update
    void Start()
    {
        oxygenBar = GetComponent<Slider>();
        oxygenBar.maxValue = playerOxygen._maxOxygen;
        oxygenBar.value = playerOxygen.oxygen;
        oxygen = playerOxygen.oxygen;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOxygen._horizontal != 0 || playerOxygen._vertical != 0)
        {
            oxygenBar.value -= oxygenLess;
            oxygen -= oxygenLess;
            playerOxygen.oxygen -= oxygenLess;
        }
    }
}
