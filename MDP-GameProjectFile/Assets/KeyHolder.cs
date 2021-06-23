using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    private List<key.KeyType> KeyList;

    private void Awake()
    {
        KeyList = new List<key.KeyType>();
    }
    public void AddKey(key.KeyType keyType)
    {
        KeyList.Add(keyType);
    }
    public void RemoveKey(key.KeyType keytype) 
    {
        KeyList.Remove(keytype);
    }
    public bool ContainsKey(key.KeyType keytype)
    {
        return KeyList.Contains(keytype);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        key key = collider.GetComponent<key>();
        if (key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }
    }









}
