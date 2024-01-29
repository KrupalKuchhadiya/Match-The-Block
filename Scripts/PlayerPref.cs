using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPref : MonoBehaviour
{
    [SerializeField]
    Button[] AllButton;
    public static PlayerPref pref;
    private void Awake()
    {
        pref = this;
    }

    private void Start()
    {
        int Value = PlayerPrefs.GetInt("Level", 0);
        for(int i = 0;i <= Value;i++)
        {
            AllButton[i].interactable = true;
            AllButton[i].gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public void SetAllLevel(int ClickedButton)
    {
        int Value = PlayerPrefs.GetInt("Level", 0);
        if (ClickedButton == Value)
        {
            //Value++;
            PlayerPrefs.SetInt("Level", Value);
        }
        RefreshData();
    }

    public void RefreshData()
    {
        int Value = PlayerPrefs.GetInt("Level", 0);
        for (int i = 0; i <= Value; i++)
        {
            AllButton[i].interactable = true;
            //AllButton[i].gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

}
