using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Diretor _diretor;
    private Pontuacao _pontuacao;


    [SerializeField]
    private float force = 5f;
    [SerializeField]
    private GameObject posInicial;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();        
        transform.position = posInicial.transform.position;
    }

    private void Start()
    {
        _diretor = FindObjectOfType<Diretor>();
        _pontuacao = FindObjectOfType<Pontuacao>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _rb.velocity = Vector2.zero;
            _rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _rb.simulated = false;
        _diretor.FinalizarJogo();
    }

   public void Reiniciar()
    {
        _rb.simulated = true;
        transform.position = posInicial.transform.position;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstaculo"))
        {
            _pontuacao.Pontuar();
        }
    }
}
