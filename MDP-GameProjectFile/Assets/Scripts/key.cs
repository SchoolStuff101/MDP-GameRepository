using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{

    [SerializeField] private KeyType keyType;
    public enum KeyType
    {
      Yellow,
      Green,
      Blue,
      Red


    }
    public KeyType GetKeyType()
    {
        return keyType;
    }


}
