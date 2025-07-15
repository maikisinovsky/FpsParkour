using UnityEngine;

public class InteractuarConE : MonoBehaviour
{
    public GameObject interactionMessage;

    public MoneyManager moneyManager;

    public MercanciaScript Mercancia;

    void Start()
    {
        interactionMessage.SetActive(false);
        moneyManager = FindFirstObjectByType<MoneyManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Mercancia)
            {
                moneyManager.UpdateMoney(-1);
                Destroy(Mercancia.gameObject);
                StopInteraction();
            }
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log(other.gameObject.name);
        Mercancia = other.GetComponent<MercanciaScript>(); // CORREGIDO
        if (Mercancia)
        {
            interactionMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

    void StopInteraction()
    {
        interactionMessage.SetActive(false);
        Mercancia = null;
    }
}
