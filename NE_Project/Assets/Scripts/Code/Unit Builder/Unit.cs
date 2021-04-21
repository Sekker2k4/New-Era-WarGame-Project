using Code.Doctrine_System;
using Code.Skills_System;
using Code.Weapon_Skills_System;
using UnityEngine;

namespace Code.Unit_Builder
{
    public class Unit : MonoBehaviour
    {
        [Header("Skills")]
        public FirstSkill skill1;
        public SecondSkill skill2;
        public ThirdSkill skill3;
        public FourthSkill skill4;
        public FifthSkill skill5;
        
        public WeaponItem[] weapons;
        public Transform[] itemsHandlers;
        
        public DoctrineClass[] doctrinesClasses;
        public DoctrineRace[] doctrineRaces;
        public DoctrinePowerUp[] doctrinePowerUps;
        
        public GameObject unitModel;
        public Animator unitAnimator;
        public Sprite unitIcon;
        
        public MonoBehaviour unitController;
        public Canvas unitHud;
        public AudioClip[] unitAudio;
        

        public void SetComponents()
        {
        }
    }
}
