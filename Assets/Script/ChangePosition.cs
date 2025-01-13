using UnityEngine;
using UnityEngine.InputSystem;

public class ChangePosition : MonoBehaviour
{
    public InputActionReference action;

    // Due posizioni tra cui alternare
    private Vector3 initialPosition = new Vector3(0, 0, 0);  // Posizione iniziale
    private Vector3 outOfBoxPosition = new Vector3(15, 0, 15);  // Posizione fuori dalla scatola
    private bool isAtInitialPosition = true;  // Variabile per tenere traccia della posizione attuale

    void Start()
    {
        // Abilita l'azione
        action.action.Enable();

        // Ascolta l'evento quando l'azione è eseguita
        action.action.performed += (cxt) =>
        {
            // Alterna tra le due posizioni
            if (isAtInitialPosition)
            {
                transform.position = outOfBoxPosition;  // Sposta l'oggetto fuori dalla scatola
            }
            else
            {
                transform.position = initialPosition;  // Riporta l'oggetto alla posizione iniziale
            }

            // Inverti lo stato della variabile
            isAtInitialPosition = !isAtInitialPosition;
        };
    }

    void Update()
    {
        // Non è necessario altro codice qui, visto che il movimento avviene solo all'input
    }
}



