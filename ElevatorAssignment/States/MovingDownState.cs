using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File: States/MovingDownState.cs
namespace ElevatorAssignment.States
{
    public class MovingDownState : IElevatorState
    {
        public void MoveUp(ElevatorContext context)
        {
            // Cannot move up while moving down
        }

        public void MoveDown(ElevatorContext context)
        {
            // Already moving down, no action needed
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
