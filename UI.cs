using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI pointsText;
    public GameObject defeatUI;

    void Update()
    {
        pointsText.text = player.point.ToString();

        if (player == null)
        {
            defeatUI.SetActive(true);
        }
    }
}
