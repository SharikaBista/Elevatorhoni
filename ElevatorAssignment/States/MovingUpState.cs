using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File: States/MovingUpState.cs
namespace ElevatorAssignment.States
{
    public class MovingUpState : IElevatorState
    {
        public void MoveUp(ElevatorContext context)
        {
            // Already moving up, no action needed
        }

        public void MoveDown(ElevatorContext context)
        {
            // Cannot move down while moving up
        }

        public void OpenDoor(ElevatorContext context)
        {
            // Cannot open door while moving
        }

        public void CloseDoor(ElevatorContext context)
        {
            // Cannot close door while moving
        }

        public void Stop(ElevatorContext context)
        {
            context.SetState(context.IdleState);
            context.ElevatorForm.StopMoving();
        }
    }
}

