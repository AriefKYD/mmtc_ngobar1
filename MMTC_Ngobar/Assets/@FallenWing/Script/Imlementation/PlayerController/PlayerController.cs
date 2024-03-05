
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallenWing.Module.HFSM;
using NaughtyAttributes;
using FallenWing.Module.EventManager;
public class PlayerController : HFSM_Factory<PlayerController.PlayerState, PlayerController>
{
    public enum PlayerState
    {

    }
    protected override void Awake()
    {
        base.Awake();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

  
}