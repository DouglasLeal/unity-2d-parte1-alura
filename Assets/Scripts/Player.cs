using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField]
    private float force = 5f;

    private void Awake()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _rb.velocity = Vector2.zero;
            _rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
}
