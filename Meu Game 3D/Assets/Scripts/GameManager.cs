using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int monedas;
    public TMP_Text hud, vitoria;
    public AudioClip ClipMoeda, ClipVitoria;

    private AudioSource source;
    void Start()
    {
    monedas = FindObjectsOfType<Coin>().Length;
    TryGetComponent(out source);

    }
    public void atualizarHUD()
    {
        hud.text = $"moedas restantes: {monedas}";
    }

    public void subtrairCoins(int valor)
    {
        monedas -= valor;
        atualizarHUD();
        source.PlayOneShot(ClipMoeda);

        if (monedas <= 0)
        {
            vitoria.text = "Saba mt slk";
            source.PlayOneShot(ClipVitoria);
            source.Stop();
        }
        
    }
   
    
    
    
    
    
}
