using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Este m�todo se llama cuando el mouse hace clic en el objeto
    private void OnMouseDown()
    {
        Debug.Log("Nota del xil�fono presionada");
        //Reproducir sonido
        GetComponent<AudioSource>().Play();

    }

}
