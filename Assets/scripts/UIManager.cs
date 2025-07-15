using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    void Start()
    {
        
    }

    public void UpdateMoneytxt(string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }
}
