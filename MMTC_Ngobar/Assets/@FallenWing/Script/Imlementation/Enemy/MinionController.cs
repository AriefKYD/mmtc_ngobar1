using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallenWing.Module.FSM;
namespace FallenWing.Behavior.NPC.Minion
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class MinionController : FSM_Factory<MinionController.MinionState, MinionController>
    {
        public enum MinionState
        {
            Idle,
            Chase,
            Patrol,
            Stunned,
            Attack
        }
        private Rigidbody2D rb;
        private Animator animator;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();

            InitializeStates();
        }

        private void InitializeStates()
        {
            states.Add(MinionState.Idle, new FSM_MinionIdle(MinionState.Idle, this));
            states.Add(MinionState.Chase, new FSM_MinionChase(MinionState.Chase, this));
            states.Add(MinionState.Patrol, new FSM_MinionPatrol(MinionState.Patrol, this));
            states.Add(MinionState.Stunned, new FSM_MinionStunned(MinionState.Stunned, this));
            states.Add(MinionState.Attack, new FSM_MinionAttack(MinionState.Attack, this));
            currentState = states[MinionState.Idle];
        }

        public void SwitchState(MinionState state)
        {
            TransitionToState(state);
        }

    }

    public class FSM_MinionIdle : FSM_BaseState<MinionController.MinionState, MinionController>
    {
        public FSM_MinionIdle(MinionController.MinionState stateKey, MinionController controller) : base(stateKey, controller)
        {
        }

        public override void DoOnEnterState()
        {

        }

        public override void DoOnExitState()
        {

        }

        public override void DoOnStateFixedUpdate()
        {

        }

        public override void DoOnStateUpdate()
        {

        }

        public override MinionController.MinionState NextState()
        {
            return MinionController.MinionState.Idle;
        }
    }
    
    public class FSM_MinionChase : FSM_BaseState<MinionController.MinionState, MinionController>
    {
        public FSM_MinionChase(MinionController.MinionState stateKey, MinionController controller) : base(stateKey, controller)
        {
        }

        public override void DoOnEnterState()
        {

        }

        public override void DoOnExitState()
        {

        }

        public override void DoOnStateFixedUpdate()
        {

        }

        public override void DoOnStateUpdate()
        {

        }

        public override MinionController.MinionState NextState()
        {
            return MinionController.MinionState.Idle;
        }
    } 
    public class FSM_MinionAttack : FSM_BaseState<MinionController.MinionState, MinionController>
    {
        public FSM_MinionAttack(MinionController.MinionState stateKey, MinionController controller) : base(stateKey, controller)
        {
        }

        public override void DoOnEnterState()
        {

        }

        public override void DoOnExitState()
        {

        }

        public override void DoOnStateFixedUpdate()
        {

        }

        public override void DoOnStateUpdate()
        {

        }

        public override MinionController.MinionState NextState()
        {
            return MinionController.MinionState.Idle;
        }
    }  
    
    public class FSM_MinionPatrol : FSM_BaseState<MinionController.MinionState, MinionController>
    {
        public FSM_MinionPatrol(MinionController.MinionState stateKey, MinionController controller) : base(stateKey, controller)
        {
        }

        public override void DoOnEnterState()
        {

        }

        public override void DoOnExitState()
        {

        }

        public override void DoOnStateFixedUpdate()
        {

        }

        public override void DoOnStateUpdate()
        {

        }

        public override MinionController.MinionState NextState()
        {
            return MinionController.MinionState.Idle;
        }
    }
    
    public class FSM_MinionStunned : FSM_BaseState<MinionController.MinionState, MinionController>
    {
        public FSM_MinionStunned(MinionController.MinionState stateKey, MinionController controller) : base(stateKey, controller)
        {
        }

        public override void DoOnEnterState()
        {

        }

        public override void DoOnExitState()
        {

        }

        public override void DoOnStateFixedUpdate()
        {

        }

        public override void DoOnStateUpdate()
        {

        }

        public override MinionController.MinionState NextState()
        {
            return MinionController.MinionState.Idle;
        }
    }



}