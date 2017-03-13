using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto2 : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Scores.Resultado("Izquierda");
        }
    }
}
