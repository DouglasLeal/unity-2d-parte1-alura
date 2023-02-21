using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculo : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 3;

    [SerializeField]
    private GameObject obstaculo;

    private float cronometro;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;

        if(this.cronometro < 0 ) 
        {
            cronometro = tempoParaGerar;
            GameObject.Instantiate(obstaculo, transform.position, Quaternion.identity);
        }
    }
}
