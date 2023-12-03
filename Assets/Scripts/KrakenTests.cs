using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KrakenTests : MonoBehaviour
{
    [SerializeField] private Image _box;
    [SerializeField] Dialogue _dialogue;
    [SerializeField] GameObject _diabox;
    [SerializeField] public Image _portrait;

    private void Start()
    {
        _portrait.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        CharacterController character = other.gameObject.GetComponent<CharacterController>();

        if (character != null)
        {
            //spawn ui needed
            Debug.Log("character found!");
            _box.enabled = true;
            _diabox.SetActive(true);
            _portrait.enabled = true;
            _dialogue.startDialogue();
        }
    }

    public void PortraitOff()
    {
        _portrait.enabled = false;
    }
}
