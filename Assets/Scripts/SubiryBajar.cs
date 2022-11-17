using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubiryBajar : MonoBehaviour
{
    private Vector3 inicial;
    public Vector3 incremento;
    private Vector3 posicionfin;
    private bool techo = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (techo == true)
        {
            inicial = transform.position;
            posicionfin = inicial + incremento * Time.deltaTime;
            transform.position = posicionfin;
            if (this.transform.position.y > 1)
            {
                techo = false;
            }
        }else{
            inicial = transform.position;
            posicionfin = inicial - incremento * Time.deltaTime;
            transform.position = posicionfin;

            if (this.transform.position.y < -1)
            {
                techo = true;
            }
        }
        
    }
}
