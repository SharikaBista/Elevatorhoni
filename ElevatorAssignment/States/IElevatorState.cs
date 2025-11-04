using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorAssignment.States
{
    public interface IElevatorState
    {
        void MoveUp(ElevatorContext context);
        void MoveDown(ElevatorContext context);
        void OpenDoor(ElevatorContext context);
        void CloseDoor(ElevatorContext context);
        void Stop(ElevatorContext context);
    }
}
