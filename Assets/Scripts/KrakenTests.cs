using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KrakenTests : MonoBehaviour
{
    [SerializeField] private Image _box;
  
    private void OnTriggerEnter(Collider other)
    {
        CharacterController character = other.gameObject.GetComponent<CharacterController>();

        if (character != null)
        {
            //spawn ui needed
            Debug.Log("character found!");
            _box.enabled = true;
            
        }
    }
}
