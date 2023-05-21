using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instrucciones : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject controles;
    [SerializeField] GameObject objetivo;
    [SerializeField] GameObject enemigo;

    public void Menu()
    {
        controles.SetActive(false);
        objetivo.SetActive(false);
        enemigo.SetActive(false);
        menu.SetActive(true);
    }
    public void Controles()
    {
        menu.SetActive(false);
        objetivo.SetActive(false);
        controles.SetActive(true);
    }
    public void Objetivo()
    {
        controles.SetActive(false);
        enemigo.SetActive(false);
        objetivo.SetActive(true);
    }
    public void Enemigo()
    {
        objetivo.SetActive(false);
        enemigo.SetActive(true);
    }
}
