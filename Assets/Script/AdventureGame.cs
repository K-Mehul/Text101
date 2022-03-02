using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State firstState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = firstState;
        textComponent.text = state.GetStoryText();

    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState() {
        var nextStates = state.GetNextState();
        for(int index = 0 ; index < nextStates.Length ; index++) {
         if(Input.GetKeyDown(KeyCode.Alpha1 + index)) {
             state = nextStates[0];
        }
     }
    textComponent.text = state.GetStoryText();
    }
}
