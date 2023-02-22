using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;

    private Player _aviao;

    private void Start()
    {
        _aviao = FindObjectOfType<Player>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1;
        imagemGameOver.SetActive(false);
        _aviao.Reiniciar();

        DestruirObstaculos();
    }

    private void DestruirObstaculos()
    {
        var obstaculos = FindObjectsOfType<Obstaculo>();

        foreach (var obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
