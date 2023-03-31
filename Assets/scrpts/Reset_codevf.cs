using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_codevf : MonoBehaviour

{
    [SerializeField]
    private TextLogControlvf logControl1;

    public void key_pressed()
    {
       logControl1.delete_all();
    }

}


