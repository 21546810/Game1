using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   [SerializeField] private int _playerHealth = 3;
   public Text healthUI;

   private void Start()
   {
       healthUI.text = "Health = " + _playerHealth;
   }

   public void AddHealth(int heathToAdd)
    {
        _playerHealth += heathToAdd;
        healthUI.text = "Health = " + _playerHealth;
    }

    public void RemoveHealth(int healthToRemove)
    {
        _playerHealth -= healthToRemove;
        healthUI.text = "Health = " + _playerHealth;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            RemoveHealth(1);
        }

        if (col.gameObject.CompareTag("Health"))
        {
            AddHealth(1);
        }
    }
}
