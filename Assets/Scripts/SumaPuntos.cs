using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaPuntos : MonoBehaviour
{
    public Puntos punt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     punt.SumarPuntos(1*Time.deltaTime);
    }
}
