using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Este método se llama cuando el mouse hace clic en el objeto
    private void OnMouseDown()
    {
        Debug.Log("Nota del xilófono presionada");
        //Reproducir sonido
        GetComponent<AudioSource>().Play();

    }

}
