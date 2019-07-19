using System;
using System.Collections.Generic;
using System.Text;

namespace Shaiya.Infrastructure
{
    public class BaseCharacter
    {
        public string Height { get; set; }
        public string Width { get; set; }
        public bool isPlayable { get; set; }
        public string HealthPoints { get; set; }
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public double ZPosition { get; set; }
        public string AttackPoints { get; set; }
        public string SkillPoints { get; set; }
        public string Attack1 { get; set; }
        public string Attack2 { get; set; }
        public string Attack3 { get; set; }
        public string Attack4 { get; set; }
        public string SpecialAttack { get; set; }
        public double MovementSpeed { get; set; }
        public bool isDead { get; set; }
        public bool isStunned { get; set; }
    }
}
