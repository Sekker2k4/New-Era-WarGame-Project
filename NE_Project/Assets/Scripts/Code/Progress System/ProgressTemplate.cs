using UnityEngine;

namespace Code.Progress_System
{
    public abstract class ProgressTemplate : MonoBehaviour
    {
        protected virtual void Progression()
        {
        }

        protected virtual void InitialPoints()
        {
        }

        protected virtual void PointsByDeath()
        {
        }

        protected virtual void PointsByVictory()
        {
        }

        protected virtual void PointsByDefeat()
        {
        }

        protected virtual void Buy()
        {
        }

        protected virtual void Sell()
        {
        }
    }
}
