using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar : MonoBehaviour
{
    public bool status=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(status == true){
            gameObject.SetActive(false);
        }else{
            gameObject.SetActive(true);
        }
    }
}
