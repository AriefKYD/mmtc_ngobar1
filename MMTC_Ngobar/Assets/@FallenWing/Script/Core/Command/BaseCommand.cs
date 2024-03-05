using System.Collections;
using UnityEngine;
namespace FallenWing.Core
{
    public abstract class BaseCommand
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}