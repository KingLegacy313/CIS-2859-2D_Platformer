using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour
{
    PlatformerPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlatformerPlayer>();
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

}
