using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private float maxY = 1.9f;
    private float minY = -1.3f;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(maxY, minY));
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if(transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }
}
