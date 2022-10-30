using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    private TextMeshProUGUI textmesh;
    private float puntos;
    private void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textmesh.text = puntos.ToString("0");
    }

    public void SumarPuntos(float entrada)
    {
        puntos += entrada;

    }
    public float GetPuntos()
    {
        return puntos;
    }
}

 