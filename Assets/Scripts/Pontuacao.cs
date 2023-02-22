using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int _pontos;

    [SerializeField]
    private Text _textoPontuacao;

    public void Pontuar()
    {
        _pontos++;
        _textoPontuacao.text = _pontos.ToString();
    }

    public void Zerar()
    {
        _pontos = 0;
        _textoPontuacao.text = _pontos.ToString();
    }
}
