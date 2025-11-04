using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorAssignment.States
{
    public class ElevatorContext
    {
        public IElevatorState CurrentState { get; private set; }
        public Form1 ElevatorForm { get; private set; }

        public IdleState IdleState { get; }
        public MovingUpState MovingUpState { get; }
        public MovingDownState MovingDownState { get; }
        public DoorOpeningState DoorOpeningState { get; }
        public DoorClosingState DoorClosingState { get; }

        public ElevatorContext(Form1 form)
        {
            ElevatorForm = form;

            // Initialize all states
            IdleState = new IdleState();
            MovingUpState = new MovingUpState();
            MovingDownState = new MovingDownState();
            DoorOpeningState = new DoorOpeningState();
            DoorClosingState = new DoorClosingState();

            CurrentState = IdleState;
        }

        public void SetState(IElevatorState state)
        {
            CurrentState = state;
        }

        public void MoveUp() => CurrentState.MoveUp(this);
        public void MoveDown() => CurrentState.MoveDown(this);
        public void OpenDoor() => CurrentState.OpenDoor(this);
        public void CloseDoor() => CurrentState.CloseDoor(this);
        public void Stop() => CurrentState.Stop(this);
    }
}
