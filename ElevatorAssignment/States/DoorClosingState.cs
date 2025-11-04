using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File: States/CloseDoorState.cs
namespace ElevatorAssignment.States
{
    public class DoorClosingState : IElevatorState
    {
        public void MoveUp(ElevatorContext context)
        {
            // Cannot move while door is closing
        }

        public void MoveDown(ElevatorContext context)
        {
            // Cannot move while door is closing
        }

        public void OpenDoor(ElevatorContext context)
        {
            // Cannot open while still closing
        }

        public void CloseDoor(ElevatorContext context)
        {
            // Already closing, no action needed
        }

        public void Stop(ElevatorContext context)
        {
            context.SetState(context.IdleState);
            context.ElevatorForm.StopDoorMovement();
        }
    }
}
