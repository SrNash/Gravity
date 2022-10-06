using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FuelBar : MonoBehaviour
{
    public Slider fuelBar;
    [SerializeField]
    PlayerController playerFuel; 
    public float maxFuel;
    [SerializeField]
    float fuel;
    [SerializeField]
    public TMP_Text fuelPoints;

    // Start is called before the first frame update
    void Start()
    {
        fuelBar = GetComponent<Slider>();
        fuelBar.maxValue = playerFuel._maxFuel;
        fuelBar.value = playerFuel.currentFuel;
        fuel = playerFuel.currentFuel;
    }

    // Update is called once per frame
    void Update()
    {
        fuelBar.value = playerFuel.currentFuel;
        fuel = playerFuel.currentFuel;
        fuelPoints.text = playerFuel.currentFuel.ToString() + " %";
    }
}
