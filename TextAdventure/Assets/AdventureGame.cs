using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent; //serializeField makes this editable in the inspector
    [SerializeField] State StartingState;


    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (int i = 0; i < nextStates.Length; i++) {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[0];
                textComponent.text = state.GetStateStory();
            }
        }
    }
}
