using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YouWin : MonoBehaviour
{
    public TMP_Text youWinTxt;

    [SerializeField]
    GameObject youWinPrefab;
    public GameObject youWin;

    [SerializeField]
    GameObject bigBoyPrefab;

    public GameObject enemy;

    public GameObject bigBoy;

    public GameObject player;

    public GameObject trigger;

    private bool isCreated = false;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        player.GetComponent<PlatformerPlayer>().enabled = true;
    }

    void Update()
    {
        if (isCreated == false && GameObject.FindWithTag("Enemy") == null)
        {
            bigBoy = Instantiate(bigBoyPrefab) as GameObject;
            bigBoy.transform.position = new Vector3(30f, 15.6f, 0f);
            Destroy(GameObject.FindWithTag("Trigger"));
            isCreated = true;
        }

        if (!bigBoy && !youWin && !trigger)
            {
                player.GetComponent<PlatformerPlayer>().enabled = false;
                youWin = Instantiate(youWinPrefab) as GameObject;
                youWinTxt.text = "You Win!";

            }
    }
}
