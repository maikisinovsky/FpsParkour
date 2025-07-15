using UnityEngine;

public class MoneyManager : MonoBehaviour
{


    public float money;
    public UIManager uiManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiManager.UpdateMoneytxt(money.ToString());
    }

    public void UpdateMoney(float moneyToAdd)
    {
        if (money + moneyToAdd < 0)
        {
            Debug.Log("no te alcanza :(");
            return;
        }
        money += moneyToAdd;
        uiManager.UpdateMoneytxt(money.ToString());
    }
}
