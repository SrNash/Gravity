using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRandomGenerator : MonoBehaviour
{
    ///<summary>
    ///En este script trataré de crear de manera aleatoria
    /// tanto la posición, como la ubicación y el tamaño que
    /// navegaran por el fondo tratando así de crear un efecto
    /// PARALLAx
    ///</summary><
    
    //Array de los Sprites de los Planetas
    [SerializeField]
    GameObject[] planetSprites;

    //Variable de Escalado de los Planetas
    [SerializeField]
    float planetRandomScale;

    //Variables de desición de punto de partida y punto final
    [SerializeField]
    Vector3 initialPoint;
    [SerializeField]
    Vector3 finalPouint;

    //Variable de control de velocidad
    [SerializeField]
    float smoothSpeed;

    //Variables de control de tiempo
    [SerializeField]
    float timer, timerRandom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Función donde realizaremos el proceso de Creación,
    /// Ubicación y Escalado de los diferentes planetas y
    /// a qué tiempos se generarán de manera aleatoria.
    /// </summary>
    private void PlanetGeneration(GameObject sprite)
    {
        GameObject spritePlanet = sprite;
        spritePlanet.GetComponent<Transform>().position = initialPoint;
        planetRandomScale= Random.Range(1f,3f);
        smoothSpeed = Random.Range(.125f,.33f);
        spritePlanet.GetComponent<Transform>().localScale = new Vector3 (planetRandomScale, planetRandomScale, planetRandomScale);
    }
}
