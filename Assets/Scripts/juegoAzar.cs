using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class juegoAzar : MonoBehaviour
{
    int jugador1;
    int jugador2;
    int jugador3;
    string opciones;
    bool opcionfinal = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void BotonReiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
