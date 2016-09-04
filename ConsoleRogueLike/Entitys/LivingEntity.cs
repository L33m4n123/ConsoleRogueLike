//
//  Author:
//    Patrick 'Leeman' Lehmann lehmann.s.patrick@gmail.com
//
//  Copyright (c) 2016, Leeman
//
//  All rights reserved.
//
//  Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in
//       the documentation and/or other materials provided with the distribution.
//     * Neither the name of the [ORGANIZATION] nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
//  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
//  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
//  A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
//  CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
//  EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
//  PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
//  LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
//  NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
using System;

namespace ConsoleRogueLike
{
    /// <summary>
    /// Living entity.
    /// 
    /// Deals everything every living Entity needs in the game
    /// </summary>
    public class LivingEntity : Entity
    {

        #region Parameters

        public Faction Faction { get; set; }

        public float Hitpoints 
        { 
            get
            {
                return this._hitpoints;
            }
            set
            {
                this._hitpoints = value;
                if (this._hitpoints <= 0)
                {
                    this.Die();
                }
            }
        }


        // For Combat
        public float Damage { get; set; }
        public float Armor { get; set; }
        public float ViewRange { get; set; }

        #endregion

        #region private fields
        float _hitpoints;
        #endregion

        public LivingEntity(String name, String desc, Chixel chixel, float hp, Faction faction, float damage = 1.0f, float armor = 1.0f, float viewRange = 1.0f) : base(name, desc, chixel)
        {
            this.Hitpoints = hp;
            this.Faction = faction;
            this.Damage = damage;
            this.Armor = armor;
            this.ViewRange = viewRange;
        }

        public void TakeDamage(float ammount)
        {
            if ((ammount - this.Armor) < 1)
            {
                ammount = 1;
            }

            this.Hitpoints = this.Hitpoints - ammount;
        }

        public void Die()
        {
            // TODO: Take care of Death of the Entity
        }

    }
}

