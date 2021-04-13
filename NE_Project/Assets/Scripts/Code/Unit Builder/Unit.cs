using UnityEngine;

namespace Code.Unit_Builder
{
    public class Unit : MonoBehaviour
    {
        public Skills[] skills;
        public Weapon[] weapons;
        public Doctrine[] doctrines;
        public GameObject unitModel;
        public Animator unitAnimator;
        public Sprite unitIcon;
        public Transform[] itemsHandlers;
        public MonoBehaviour unitController;
        public Canvas unitHud;
        public AudioClip[] unitAudio;
        

        public void SetComponents()
        {
        }
    }
}
