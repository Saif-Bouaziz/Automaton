using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_codevf : MonoBehaviour
{
    [SerializeField]
    private TextLogControlvf logControl2;

    public void key_pressed1()
    {
        logControl2.delete_last() ;   
    }
}
