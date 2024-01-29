using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<GameObject> EmptyObject;
    public List<GameObject> Player;
    public int Count = 0;
    public bool flag1;
    public GameObject GameOverPanel, GameWinPanel;
    public List<GameObject> AlreadyExist;
    public Transform CHILD, CHILD1, CHILD2;
    public void Awake()
    {
        Instance = this;
        flag1 = true;
    }
    public void NextScene()
    {
        SceneManager.LoadScene("AllLevelScene");
    }
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Checker()
    {
        if (EmptyObject[0].transform.childCount == 1)
        {
            if (EmptyObject[1].transform.childCount == 1)
            {
                if (EmptyObject[2].transform.childCount == 1)
                {
                    if (EmptyObject[0].transform.GetChild(0).tag == EmptyObject[1].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[1].transform.GetChild(0).tag == EmptyObject[2].transform.GetChild(0).tag)
                        {

                            foreach (Transform child in EmptyObject[0].transform)
                            {
                                CHILD = child;
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                                StartCoroutine(DestroyWait(3));
                            }
                            foreach (Transform child in EmptyObject[1].transform)
                            {
                                CHILD1 = child;
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                                StartCoroutine(DestroyWait(3));
                            }
                            foreach (Transform child in EmptyObject[2].transform)
                            {
                                CHILD2 = child;
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                                StartCoroutine(DestroyWait(3));
                            }
                            if (flag1)
                            {
                                Count = 0;

                                flag1 = false;
                            }
                            else
                            {
                                Count++;
                            }
                            flag1 = true;

                        }
                    }
                }
            }
        }
        if (EmptyObject[1].transform.childCount == 1)
        {
            if (EmptyObject[2].transform.childCount == 1)
            {
                if (EmptyObject[3].transform.childCount == 1)
                {
                    if (EmptyObject[1].transform.GetChild(0).tag == EmptyObject[2].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[2].transform.GetChild(0).tag == EmptyObject[3].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[1].transform)
                            {
                                CHILD = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[2].transform)
                            {
                                CHILD1 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[3].transform)
                            {
                                CHILD2 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }

                            if (flag1)
                            {
                                Count = 1;

                                flag1 = false;
                            }
                            else
                            {

                                Count++;
                            }
                            flag1 = true;

                        }
                    }
                }
            }

        }
        if (EmptyObject[2].transform.childCount == 1)
        {
            if (EmptyObject[3].transform.childCount == 1)
            {
                if (EmptyObject[4].transform.childCount == 1)
                {
                    if (EmptyObject[2].transform.GetChild(0).tag == EmptyObject[3].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[3].transform.GetChild(0).tag == EmptyObject[4].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[2].transform)
                            {
                                CHILD = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[3].transform)
                            {
                                CHILD1 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[4].transform)
                            {
                                CHILD2 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }

                            if (flag1)
                            {
                                Count = 2;

                                flag1 = false;
                            }
                            else
                            {

                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }
        if (EmptyObject[3].transform.childCount == 1)
        {
            if (EmptyObject[4].transform.childCount == 1)
            {
                if (EmptyObject[5].transform.childCount == 1)
                {
                    if (EmptyObject[6].transform.GetChild(0).tag == EmptyObject[4].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[4].transform.GetChild(0).tag == EmptyObject[5].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[3].transform)
                            {
                                CHILD = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[4].transform)
                            {
                                CHILD1 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[5].transform)
                            {
                                CHILD2 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }

                            if (flag1)
                            {
                                Count = 3;

                                flag1 = false;
                            }
                            else
                            {
                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }
        if (EmptyObject[4].transform.childCount == 1)
        {
            if (EmptyObject[5].transform.childCount == 1)
            {
                if (EmptyObject[6].transform.childCount == 1)
                {
                    if (EmptyObject[4].transform.GetChild(0).tag == EmptyObject[5].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[5].transform.GetChild(0).tag == EmptyObject[6].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[4].transform)
                            {
                                CHILD = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[5].transform)
                            {
                                CHILD1 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[6].transform)
                            {
                                CHILD2 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
;
                            if (flag1)
                            {
                                Count = 4;

                                flag1 = false;
                            }
                            else
                            {
                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }
        if (EmptyObject[5].transform.childCount == 1)
        {
            if (EmptyObject[6].transform.childCount == 1)
            {
                if (EmptyObject[7].transform.childCount == 1)
                {
                    if (EmptyObject[5].transform.GetChild(0).tag == EmptyObject[6].transform.GetChild(0).tag)
                    {
                        if (EmptyObject[6].transform.GetChild(0).tag == EmptyObject[7].transform.GetChild(0).tag)
                        {
                            foreach (Transform child in EmptyObject[5].transform)
                            {
                                CHILD = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[6].transform)
                            {
                                CHILD1 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }
                            foreach (Transform child in EmptyObject[7].transform)
                            {
                                CHILD2 = child;
                                StartCoroutine(DestroyWait(3));
                                PlayerScript.instance.PlayerAnimation.SetBool("happy", false); PlayerScript.instance.PlayerAnimation.SetBool("walk", true);
                            }

                            if (flag1)
                            {
                                Count = 5;
                                flag1 = false;
                            }
                            else
                            {
                                Count++;
                            }
                            flag1 = true;
                        }
                    }
                }
            }
        }


        StartCoroutine(MainCheck(5));
    }

    IEnumerator MainCheck(int Time)
    {
        yield return new WaitForSeconds(Time);
        if (AlreadyExist.Count == 0)
        {
            if (EmptyObject[0].transform.childCount == 0)
            {
                if (EmptyObject[1].transform.childCount == 0)
                {
                    if (EmptyObject[2].transform.childCount == 0)
                    {
                        if (EmptyObject[3].transform.childCount == 0)
                        {
                            if (EmptyObject[4].transform.childCount == 0)
                            {
                                /***/
                                if (EmptyObject[5].transform.childCount == 0)
                                {
                                    Debug.Log("Win");
                                    GameWinPanel.SetActive(true);
                                    GameOverPanel.SetActive(false);
                                }
                                else if (EmptyObject[5].transform.childCount != 0)
                                {
                                    Debug.Log("Lose");
                                    GameWinPanel.SetActive(false);
                                    GameOverPanel.SetActive(true);
                                }
                            }
                            else if (EmptyObject[4].transform.childCount != 0)
                            {
                                    Debug.Log("Lose");
                                GameWinPanel.SetActive(false);
                                GameOverPanel.SetActive(true);
                            }
                        }
                        else if (EmptyObject[3].transform.childCount != 0)
                        {
                                    Debug.Log("Lose");
                            GameWinPanel.SetActive(false);
                            GameOverPanel.SetActive(true);
                        }
                    }
                    else if (EmptyObject[2].transform.childCount != 0)
                    {
                                    Debug.Log("Lose");
                        GameWinPanel.SetActive(false);
                        GameOverPanel.SetActive(true);
                    }
                }
                else if (EmptyObject[1].transform.childCount != 0)
                {
                                    Debug.Log("Lose");
                    GameWinPanel.SetActive(false);
                    GameOverPanel.SetActive(true);
                }
            }
            else if (EmptyObject[0].transform.childCount != 0)
            {
                                    Debug.Log("Lose");
                GameWinPanel.SetActive(false);
                GameOverPanel.SetActive(true);
            }
        }

        else if (AlreadyExist.Count != 0)
        {
            if (EmptyObject[6].gameObject.transform.childCount != 0)
            {
                                    Debug.Log("Lose");
                GameWinPanel.SetActive(false);
                GameOverPanel.SetActive(true);
            }
        }
    }
    public void FinalWinChecking(GameObject ClickedObject)
    {
        if (AlreadyExist.Contains(ClickedObject))
        {
            AlreadyExist.Remove(ClickedObject);
        }
    }

    public void WinNextButton()
    {
        int Value = PlayerPrefs.GetInt("Level", 0);
        Value++;
        PlayerPrefs.SetInt("Level", Value);
        PlayerPref.pref.RefreshData();
    }

    public void LoseRetryButton()
    {
        int Value = PlayerPrefs.GetInt("Level", 0);
        PlayerPrefs.SetInt("Level", Value);
        PlayerPref.pref.RefreshData();
    }

    IEnumerator DestroyWait(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        Destroy(CHILD.gameObject);
        Destroy(CHILD1.gameObject);
        Destroy(CHILD2.gameObject);
        
      
    }
}