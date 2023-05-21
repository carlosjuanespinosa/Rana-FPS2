using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaJuego : MonoBehaviour
{
    [SerializeField] private GameObject pausa;
    
    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.P))
        {
            pausa.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Time.timeScale = 1f;
    }
    public void Salir()
    {
        Application.Quit();
    }

    public void Continuar()
    {
        pausa.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
