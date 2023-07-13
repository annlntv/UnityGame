using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        KeysCount keys = other.GetComponent<KeysCount>();

        //Количество ключей обновляется
        keys.CollectKeys();

        //,Ключ, который собрали, уничтожается
        Destroy(gameObject);
    }
}
