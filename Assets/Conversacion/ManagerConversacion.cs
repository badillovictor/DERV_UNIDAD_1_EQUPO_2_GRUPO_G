using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerConversacion : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo
    {
        public string name;
        public string texto;
        public Sprite imagen;
    }

    public List<Dialogo> charla;

    [SerializeField] TextMeshProUGUI txtMensaje;
    [SerializeField] TextMeshProUGUI txtNombre;
    [SerializeField] Image fotoPersonaje;

    int dialogID;

    public void mostrarDialogo()
    {
        txtMensaje.text = charla[dialogID].texto;
        txtNombre.text = charla[dialogID].name;
        fotoPersonaje.sprite = charla[dialogID].imagen;
    }

    // Start is called before the first frame update
    void Start()
    {
        dialogID = 0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            dialogID++;
            dialogID %= charla.Count;
            mostrarDialogo();
        }   
    }
}
