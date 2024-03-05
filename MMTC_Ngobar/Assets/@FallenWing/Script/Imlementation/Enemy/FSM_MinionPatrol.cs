﻿using FallenWing.Module.FSM;
namespace FallenWing.Behavior.NPC.Minion
{
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
}