using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv2
{
    interface IUnit
    {
        void EquipWeapon(IWeapon playerweapon);
        int UseWeapon();

        void TakeDamage(int damage);

        void ApplyDamageAmplifier();
    }
}
