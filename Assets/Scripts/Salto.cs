using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Salto : MonoBehaviour
{
    private TextMeshProUGUI textmesh;
    private string salto = "Uncharge";
    private void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textmesh.text = salto;
    }

    public void SaltoCargado(string entrada)
    {
        salto = entrada;
    }
}
