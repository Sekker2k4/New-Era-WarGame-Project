using UnityEngine;

namespace Code.Battle_System
{
    public interface IBattleSubject
    {
        public void Subscribe(IBattleObserver iBattleObserver);
        public void Unsubscribe(IBattleObserver iBattleObserver);
        public void Notify();
    }
}
