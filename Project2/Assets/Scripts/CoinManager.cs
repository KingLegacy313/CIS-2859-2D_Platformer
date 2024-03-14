using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;

    [SerializeField]
    GameObject goldPlatPrefab;
    private GameObject goldPlat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coinCount;

        if(coinCount == 10 && goldPlat == null)
        {
            goldPlat = Instantiate(goldPlatPrefab) as GameObject;
            goldPlat.transform.position = new Vector3(-8.1f, -1.5f, 0f);
        }
    }
}
