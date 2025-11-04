using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File: States/OpenDoorState.cs
namespace ElevatorAssignment.States
{
    public class DoorOpeningState : IElevatorState
    {
        public void MoveUp(ElevatorContext context)
        {
            // Cannot move while door is opening
        }

        public void MoveDown(ElevatorContext context)
        {
            // Cannot move while door is opening
        }

        public void OpenDoor(ElevatorContext context)
        {
            // Already opening, no action needed
        }

        public void CloseDoor(ElevatorContext context)
        {
            // Cannot close while still opening
        }

        public void Stop(ElevatorContext context)
        {
            context.SetState(context.IdleState);
            context.ElevatorForm.StopDoorMovement();
        }
    }
}

