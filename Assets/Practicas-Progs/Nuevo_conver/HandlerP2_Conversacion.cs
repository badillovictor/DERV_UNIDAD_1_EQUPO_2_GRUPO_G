using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    [System.Serializable]
  public struct Dialogo{
            public string name;
            public string texto;
            public Sprite imagen;
    }
     public List<Dialogo> PLatica;

    [SerializeField] TextMeshProUGUI txt_mensaje;
    [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] Image foto_persona;



    int contador;

    void mostrarDialogo(){
        txt_mensaje.text= PLatica[contador].texto;
        txt_nombre.text = PLatica[contador].name;
        foto_persona.sprite = PLatica[contador].imagen;
    }
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        mostrarDialogo();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
        contador++;
        contador = contador++%PLatica.Count;
        Debug.Log(contador);
        mostrarDialogo();
        }
    }
}
