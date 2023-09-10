using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoItems : MonoBehaviour
{
    public ContadorItems contadorItem;
    public float ItemsNecesarios;
    public Material Material1;
    public Desactivar des;

    private void OnTriggerEnter(Collider other){

        if(other.CompareTag("Player"))
        {
            if(contadorItem.items == ItemsNecesarios){
                Debug.Log("cambiar color");
                GetComponent<MeshRenderer> ().material = Material1;
                des.status = true;
            }
        }
    }

}
