using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private int points;


    public void UpdateUI()
    {
        points += 1;
        coinText.text = points.ToString();
    }
}
