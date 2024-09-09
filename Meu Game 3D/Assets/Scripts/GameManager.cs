using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int monedas;
    public TMP_Text hud, vitoria;
    
    void Start()
    {
    monedas = FindObjectsOfType<Coin>().Length;
    
    }
    public void atualizarHUD()
    {
        hud.text = $"moedas restantes: {monedas}";
    }

    public void subtrairCoins(int valor)
    {
        monedas -= valor;
        atualizarHUD();

        if (monedas <= 0)
        {
            vitoria.text = "Saba mt slk";
        }
        
    }
   
    
    
    
    
    
}
