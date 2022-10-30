using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Salto salt;
    public Puntos punt;
 

    public float CantPunts;
    public float Speed = 0;
    public float Points = 0;

    private float Salto = 0;
    private float Recarga = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Recarga = 0;
        Salto = 0;
        Points = 0;
    }
    private void OnMove(InputValue value)
    {
        Vector2 movementVector = value.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    private void OnJump()
    {
        if (Recarga == 50)
        {
        Salto = 50;
        Recarga = 0;
        salt.SaltoCargado("UnCharge");
        }
        else
        {
        Salto = 0.0f;
        }

        
    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, Salto, movementY);
        rb.AddForce(movement * Speed);
        Salto = 0.0f;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickups"))
        {
        other.gameObject.SetActive(false);
            Points++;
            punt.SumarPuntos(CantPunts);
        }
        if (other.gameObject.CompareTag("Suelo"))
        {
            Recarga = 50;
            salt.SaltoCargado("Charge");
        }
        if (other.gameObject.CompareTag("Teleport"))
        {
            Scene camb = SceneManager.GetActiveScene();
            SceneManager.LoadScene(camb.buildIndex+1);
        }
        if (other.gameObject.CompareTag("Final"))
        {
            SceneManager.LoadScene("Menu");
        }



    }
    public float GetPoints()
    {
        return Points;
    }
   

}
