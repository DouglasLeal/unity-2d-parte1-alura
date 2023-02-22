using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int _pontos;
    private AudioSource _audioPontuar;

    [SerializeField]
    private Text _textoPontuacao;

    private void Awake()
    {
        _audioPontuar = GetComponent<AudioSource>();
    }

    public void Pontuar()
    {
        _pontos++;
        _textoPontuacao.text = _pontos.ToString();
        _audioPontuar.Play();
    }

    public void Zerar()
    {
        _pontos = 0;
        _textoPontuacao.text = _pontos.ToString();
    }
}
