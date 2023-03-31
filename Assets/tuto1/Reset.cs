using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour

{
    [SerializeField]
    private TextLogControl logControl1;

    public void key_pressed()
    {
        logControl1.delete_all();
    }

}