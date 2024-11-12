using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OfflineMethod
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public Player Player { get; }
        public ReusableData ReusableData { get; }
        public IdlingState IdlingState { get; }
        public WalkingState WalkingState { get; }
        public RunningState RunningState { get; }
        public SprintingState SprintingState { get; }

        public PlayerMovementStateMachine(Player player)
        {
            Player = player;
            ReusableData = new ReusableData();
           IdlingState = new IdlingState(this); 
           WalkingState = new WalkingState(this); 
           RunningState = new RunningState(this); 
           SprintingState = new SprintingState(this); 
        }
    }
}
