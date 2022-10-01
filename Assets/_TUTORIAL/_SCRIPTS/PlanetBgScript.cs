using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBgScript : MonoBehaviour
{
    public Transform tr;
    [SerializeField]
    float planetRandomScale;
    [SerializeField]
    Vector3 initialPoint;
    [SerializeField]
    Vector3 finalPoints;


    [SerializeField]
    float smoothSpeed;
    //Crearemos la Escala del Planeta de manera Aleatoria al generarse
    void Awake()
    {
        tr.Translate(new Vector3 (initialPoint.x,tr.position.y, tr.position.z));
        planetRandomScale= Random.Range(1f,3f);
        smoothSpeed = Random.Range(.125f,.33f);
        tr.localScale = new Vector3 (planetRandomScale, planetRandomScale, planetRandomScale);
    }

    // Update is called once per frame
    void Update()
    {
        if (tr.position.x >= finalPoints.x)
        {
            tr.Translate(finalPoints * smoothSpeed * Time.deltaTime);
        }else if(tr.position.x <= finalPoints.x){
            tr.position = new Vector3 (initialPoint.x, tr.position.y, tr.position.z);
        }
    }
}
