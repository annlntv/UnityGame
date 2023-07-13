using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysCount : MonoBehaviour
{
    //Число собранных монет
    public int keys;

    //Метод, увеличивающий число монеток
    public void CollectKeys()
    {
        keys++;
    }
}

