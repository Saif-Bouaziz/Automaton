using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backk : MonoBehaviour
{
    [SerializeField]
    private TextLogControle1 logControl2;

    public void key_pressed1()
    {
        logControl2.delete_last();
    }
}