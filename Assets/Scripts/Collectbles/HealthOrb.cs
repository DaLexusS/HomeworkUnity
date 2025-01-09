using UnityEngine;
using UnityEngine.Events;

public class HealthOrb : MonoBehaviour
{
    private bool used = false;
    private int healAmount = 25;
    public static UnityAction<int> onHealthOrbTouched;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) { return; }

        if (used) { return; }

        onHealthOrbTouched.Invoke(healAmount);
      
        gameObject.SetActive(false);

        used = true;
    }
}
