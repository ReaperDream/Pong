using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    public static int Jugador1 = 0;
    public static int Jugador2 = 0;

    public GUISkin layout;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void Resultado(string pared)
    {
        if (pared == "Derecha")
        {
            Jugador1++;
        }
        if (pared == "Izquierda")
        {
            Jugador2++;
        }
    }

    private void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 120, 120, 100, 100), "" + Jugador1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 120, 120, 100, 100), "" + Jugador2);
    }
}
