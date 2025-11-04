using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorAssignment.States
{
    public class IdleState : IElevatorState
    {
        public void MoveUp(ElevatorContext context)
        {
            context.SetState(context.MovingUpState);
            context.ElevatorForm.StartMovingUp();
        }

        public void MoveDown(ElevatorContext context)
        {
            context.SetState(context.MovingDownState);
            context.ElevatorForm.StartMovingDown();
        }

        public void OpenDoor(ElevatorContext context)
        {
            context.SetState(context.DoorOpeningState);
            context.ElevatorForm.StartOpeningDoor();
        }

        public void CloseDoor(ElevatorContext context)
        {
            context.SetState(context.DoorClosingState);
            context.ElevatorForm.StartClosingDoor();
        }

        public void Stop(ElevatorContext context)
        {
            // Already idle, no action needed
        }
    }
}
