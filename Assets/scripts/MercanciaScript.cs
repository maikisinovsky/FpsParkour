using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindFirstObjectByType<MoneyManager>();

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    }
}
