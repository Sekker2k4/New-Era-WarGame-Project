using UnityEngine;

namespace Code.Weapon_Skills_System
{
    [CreateAssetMenu(menuName = "Create Weapon", fileName = "Weapon", order = 0)]
    public class WeaponItem :ScriptableObject
    {
        public GameObject [] skills;
        //Some Data to complete the item.
    }
}
