using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public UIController uIController;
    public PlayerFeedback feedback;

    private Inventory inventory;
    private StateMachine<PlayerInput> stateMachine;    
    
    private string msj;
    private void Awake()
    {
        
    }
    private void Transitions()
    {
        var idleState = new IdleState(this);
        var collecting = new Collecting(this, idleState, 1);
        var openNotes = new OpenNotes(this, idleState);

        idleState.AddTransition(PlayerInput.Collecting, collecting);
        collecting.AddTransition(PlayerInput.NoInteraction, idleState);

        idleState.AddTransition(PlayerInput.OpenNotes, openNotes);
        openNotes.AddTransition(PlayerInput.NoInteraction, idleState);        

        stateMachine = new StateMachine<PlayerInput>(idleState);
    }
    private void Start()
    {
        Transitions();
        inventory = GetComponent<Inventory>();
    }

    public void CanPickUp(GameObject gObject)
    {
        CollectableItem ci = gObject.GetComponent<CollectableItem>();
        msj = ci.GetFeedback();
        inventory.AddToList(ci.descriptio, ci.numberNote, ci.type);
        Destroy(gObject);
        stateMachine.Feed(PlayerInput.Collecting);        
    }
    public void OpenPanel()
    {
        uIController.SetMouseForUIOpen();
    }
    public void ClosePanel()
    {
        uIController.SetMouseForUIClose();
    }
    private void Update()
    {               
        if (Input.GetKeyDown(KeyCode.I)) stateMachine.Feed(PlayerInput.OpenNotes);
        
        stateMachine.Update();
    }

    public void Collecting()
    {        
        feedback.PickUp(msj);        
    }

    public void Idle()
    {
        feedback.Standing();
    }

    public void OpenNotes()
    {
        uIController.OpenNotes();
    }
    public void SetOpen()
    {
        
    }
    public void SetClose()
    {
        
    }
}
