using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightController : MonoBehaviour
{
    private Light lightComponent;
    public InputActionReference action;

    // Array di colori tra cui alternare
    private Color[] colors = { Color.blue, Color.red, Color.green, Color.yellow };
    private int currentColorIndex = 0; // Indice del colore attuale

    void Start()
    {
        // Abilita l'azione
        action.action.Enable();

        // Ottieni il componente Light
        lightComponent = GetComponent<Light>();

        // Ascolta l'evento quando l'azione è eseguita
        action.action.performed += (cxt) =>
        {
            // Cambia il colore della luce al prossimo colore nell'array
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            lightComponent.color = colors[currentColorIndex];
        };
    }

    void Update()
    {
        // Puoi aggiungere altre logiche qui, se necessario
    }
}


