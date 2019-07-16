using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;

public class InputToCharacter : MonoBehaviour
{
    public Receiver receiver;
    private ICommand command;

    private List<InputMap> controllableCharacter = new List<InputMap>();

    private void Start()
    {
        var charachters = FindObjectsOfType<MonoBehaviour>().OfType<InputMap>();

        foreach (var c in charachters)
            controllableCharacter.Add(c);
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(kcode))
                    foreach (InputMap character in controllableCharacter)
                    {
                        character.WhenInput(kcode);
                    }
            }
        }
    }
}