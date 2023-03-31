using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using UnityEngine.UI;
using System;
public class playdo4 : MonoBehaviour
{

    public TextLogControlvf logControl2;
    //public condition cond;

    public GameObject Robot1;
    private int i = 0;

    public Sprite[] sp;
    public void KeyBoardPress()
    {
        bool test = true;
        for (int k = 0; k < logControl2.liste_cond().Count; k++)

        {
            if (logControl2.liste()[k] == logControl2.liste_cond()[k] && logControl2.liste().Count == logControl2.liste_cond().Count)
            {

                // StartCoroutine(waitBefore());


            }
            else
            {
                test = false;
                Debug.Log("erreur");
                Home(34);

                break;
            }
        }
        if (test == true)
        {
            StartCoroutine(waitBefore());
            // Home(30);
            Debug.Log("ok");
        }
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);


    }
    public void playRobot()
    {
        {
            i++;
            Robot1.GetComponent<Image>().sprite = sp[i];

        }
    }
    IEnumerator waitBefore()
    {
        for (int j = 0; j < sp.Length - 1; j++)
        {
            playRobot();
            yield return new WaitForSeconds(1);
        }
        Home(33);
    }


}