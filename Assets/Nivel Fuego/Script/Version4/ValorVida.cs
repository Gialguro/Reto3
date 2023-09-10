using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValorVida : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public Vida vida;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();    
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = vida.vida.ToString();
    }

}
