using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class TextLogControl : MonoBehaviour
{
    [SerializeField]
    private GameObject textTemplate;
    // make a list of the texts 
    private List<GameObject> textItems;
    public GameObject Robot;
    private int i = 0;
    public Sprite[] sp;
    public bool test= true;
    public int k = 0;
    
    // pour l'initialiser
    void Start()
    {
        textItems = new List<GameObject>();
    }
    public void LogText(string newTextString, Color newColor)
    {   //besh kol mara text li tzidou yetzed m louta 
        if (textItems.Count == 10)
        {
            GameObject tempItem = textItems[0]; // creer un objet temporaire 
            Destroy(tempItem.gameObject);
            textItems.Remove(tempItem);// remove the oldest item in the list 
        }

        GameObject newText = Instantiate(textTemplate) as GameObject;
        newText.SetActive(true); //activate it
        // to sent those parameters to the text item
        newText.GetComponent<TextLogItem>().SetText(newTextString, newColor);
        newText.transform.SetParent(textTemplate.transform.parent, false);
        k++;
        if (newTextString != "Move_forward()")
        {   
            
            test = false;
            //Debug.Log("erreur");
        }



        textItems.Add(newText.gameObject);
    }
    public void KeyBoardPress(string play)
    {
        if (test == false || k != 2)
        {
            Debug.Log("erreur");
            Home(7);
        }
        else
        { StartCoroutine(waitBefore()); }
    }     
    public void playRobot()
    {       
        {
            Robot.GetComponent<Image>().sprite = sp[i];
            i++;
        }
    } 
    IEnumerator waitBefore()
    {
        playRobot();
        yield return new WaitForSeconds(1);
        playRobot();
        
        Home(6);
        
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);


    }
    public void delete_all()
    {
        for (int i = 0; i < textItems.Count; i++)
        {
            Destroy(textItems[i]);
        }
    }



    public void delete_last()
    {

        Destroy(textItems[textItems.Count - 1]);
        textItems.RemoveAt(textItems.Count - 1);
    }

}