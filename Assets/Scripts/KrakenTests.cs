using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrakenTests : MonoBehaviour
{
    [SerializeField] string _whatToSay;
    //serializefield for UI elements to spawn

    private void OnTriggerEnter(Collider other)
    {
        CharacterController character = other.gameObject.GetComponent<CharacterController>();

        if (character != null)
        {
            //spawn ui needed
            Debug.Log("character found!");
        }
    }
}
