using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineSwitcher : MonoBehaviour
{

    [SerializeField]
    private CinemachineVirtualCamera runningCamera; 
    private bool isRunning= false;

    [SerializeField]
    private CinemachineVirtualCamera idleCamera;

    private Animator animator;
    private GameObject player;
    CharacterController moving;
   // private Control controlscript;
    


    private void Awake() {
        
        animator= GetComponent<Animator>();
        player = GameObject.Find("Player");
        moving = player.GetComponent<CharacterController>();
       // Debug.Log(hello.moving);
    }

private void Update() {
   // moving = player.GetComponent<CharacterController>();
    //Debug.Log(moving);
    if (moving.moving)
    {
       animator.Play("run");
    }else
    {
        animator.Play("idle");
    }
    
}


   
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void switchState(){

        if (!isRunning)
        {
            animator.Play("idle");
        }else
        {
            animator.Play("running");
        }
     
      
    }
}
