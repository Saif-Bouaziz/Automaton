using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextLogControlvf : MonoBehaviour
{
    public List<string> conditions = new List<string>();
    [SerializeField]
    

    protected GameObject textTemplate;
    // make a list of the texts 
    protected List<GameObject> textItems;
    // pour l'initialiser
    public List<string> interm = new List<string>();   

    void Start()
    {
        textItems = new List<GameObject>();
    }

    public void LogText(string newTextString, Color newColor)
    {   //besh kol mara text li tzidou yetzed m louta 
        if (textItems.Count == 20)
        {
            GameObject tempItem = textItems[0]; // creer un objet temporaire 
            Destroy(tempItem.gameObject);
            textItems.Remove(tempItem);// remove the oldest item in the list 
        }
        interm.Add(newTextString);
        GameObject newText = Instantiate(textTemplate) as GameObject;
        newText.SetActive(true); //activate it
        // to sent those parameters to the text item
        newText.GetComponent<TextLogItem>().SetText(newTextString, newColor);
        newText.transform.SetParent(textTemplate.transform.parent, false);

        textItems.Add(newText.gameObject);
    }
    public void delete_all()
    {
        for (int i = 0; i < textItems.Count; i++)
        {
            Destroy(textItems[i]);
            interm.Clear();
        }
    }
    

    public void delete_last()
    {
        
        Destroy(textItems[textItems.Count -1]);
        textItems.RemoveAt(textItems.Count - 1);
        interm.RemoveAt(interm.Count - 1);
    }
     
    public List<string> liste()
    {
        return interm;
    }
    public List<string> liste_cond()
    {
        return conditions;
    }




}
