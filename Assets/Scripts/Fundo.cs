using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;

    private Vector3 posicaoInicial;
    private float tamanhoDaImagem;
    private float tamanhoRealDaImagem;
    private float deslocamento;

    private void Awake()
    {
        posicaoInicial = transform.position;
        tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        tamanhoRealDaImagem = tamanhoDaImagem * transform.localScale.x;
    }

    void Update()
    {
        deslocamento = Mathf.Repeat(speed * Time.time, tamanhoRealDaImagem);

        transform.position = posicaoInicial + (Vector3.left * deslocamento);
    }
}
