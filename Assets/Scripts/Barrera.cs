using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrera : MonoBehaviour
{
    public float puntos;
    public float limitpuntos;
    public Puntos punt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos = punt.GetPuntos();
        if (puntos == limitpuntos)
        {
            this.gameObject.SetActive(false);
        }
    }

}
