using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int health;

    [SerializeField]
    SpriteRenderer sprite;

    void Update()
    {
        if (health <= 0)
        {
            StartCoroutine(Die());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Flash());
            health--;
        }
    }
    IEnumerator Die()
    {
        sprite.flipY = true;

        yield return new WaitForSeconds(.5f);

        Destroy(this.gameObject);
    }
    IEnumerator Flash()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
}
