using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController controller = collision.GetComponent<RubyController>();
        if (controller != null && controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
            controller.PlaySound(collectedClip);
        }
    }
}
