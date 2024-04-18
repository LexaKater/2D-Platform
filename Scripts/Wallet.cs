using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int CountCoin { get; private set; } = 0;

    public event Action AmountChenged;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coin>())
        {
            ++CountCoin;
            AmountChenged?.Invoke();
        }
    }
}
