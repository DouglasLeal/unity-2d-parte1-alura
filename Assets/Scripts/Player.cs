using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Diretor _diretor;

    [SerializeField]
    private float force = 5f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _diretor = FindObjectOfType<Diretor>();
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
}
