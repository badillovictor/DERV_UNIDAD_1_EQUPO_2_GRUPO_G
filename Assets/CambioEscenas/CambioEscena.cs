using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void cambioDeEscena(int indexEscenaGo)
    {
        SceneManager.LoadScene(indexEscenaGo);
    }

    void Update()
    {
        int escenaActual = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (escenaActual == 0)
            {
                cambioDeEscena(1);
            }
            else if (escenaActual == 1)
            {
                cambioDeEscena(2);
            }
            else
            {
                cambioDeEscena(0);
            }
        }
    }
}
