using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine<TFeed>
{
    private State<TFeed> currentState;

    public StateMachine(State<TFeed> initialState)
    {
        currentState = initialState;
    }

    public void Update () {
        var nextState = currentState.Update();
        ChangeState(nextState);
	}

    public void Feed(TFeed input)
    {
        var nextState = currentState.Feed(input);
        ChangeState(nextState);
    }

    private void ChangeState(State<TFeed> nextState)
    {
        if (nextState != null)
        {
            currentState.Exit();
            nextState.Enter();
            currentState = nextState;
        }
    }
}
