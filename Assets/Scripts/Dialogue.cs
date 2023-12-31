using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI _textComponent;
    public string[] _lines;
    public float _textspeed;
    private int index;
    [SerializeField] KrakenTests _portraitTrigger;
    [SerializeField] AudioSource _textScroll;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        _textComponent.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_textComponent.text == _lines[index])
            {
                nextLine();
            }
            else
            {
                StopAllCoroutines();
                _textComponent.text = _lines[index];
            }
        }
    }

    public void startDialogue()
    {
        index = 0;
        StartCoroutine(_typeLine());
        _textScroll.Play();
    }

    IEnumerator _typeLine()
    {
        foreach (char c in _lines[index].ToCharArray())
        {
            _textComponent.text += c;
            yield return new WaitForSeconds(_textspeed);
        }
    }

    void nextLine()
    {
        if (index < _lines.Length - 1)
        {
            index++;
            _textComponent.text = string.Empty;
            StartCoroutine(_typeLine());
        }
        else
        {
            gameObject.SetActive(false);
            _portraitTrigger.PortraitOff();
            _textScroll.Stop();
        }
    }
}

