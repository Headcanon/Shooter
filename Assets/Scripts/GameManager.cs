using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI, loseUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void Lose()
    {
        loseUI.SetActive(true);
    }
}
