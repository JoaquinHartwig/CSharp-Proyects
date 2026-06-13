using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_Based_Combat_Game
{
    internal class Unit
    {
        private int _currentHP;
        private int _maxHP;
        private int _attackPower;
        private int _healPower;
        private string _nameUnit;
        private Random _random;

        public int Hp {  get { return _currentHP; } } //Permite leer el HP actual

        public string UnitName { get { return _nameUnit; } }  // Se utiliza para poder leer es decir mostrar en el programa el HP y nombre al llamar cada objeto
        //Permitir leer _nameUnit desde afuera pero sin permitir modificarlo
        public bool IsDead { get { return _currentHP <= 0; } }// Si es mayor o igual a 0,tira true
        public Unit(int maxHP,int attackPower,int healPower, string nameUnit)
        {
            _currentHP = maxHP; //Cuando una unidad nace, empieza con toda la vida.  
            _maxHP = maxHP;
            _attackPower = attackPower;
            _healPower = healPower;
            _nameUnit = nameUnit;
            _random= new Random();


        }
        public void Attack(Unit unittoAttack)
        {
            
            double rng = _random.NextDouble();//Genera un número aleatorio entre 0.0 y 1.0 Nunca llega a 1  
            rng = rng / 2 + 0.75f;
            int RandDamage = (int)(_attackPower * rng);
            unittoAttack.TakeDamage(RandDamage);//ahora puede atacar e infligir daño
            Console.WriteLine(_nameUnit + " attacks " + unittoAttack._nameUnit + " and deals " + RandDamage + " damage!");

        }
        public void TakeDamage(int Damage)
        {
            _currentHP -= Damage;
            if (IsDead)
            {
                Console.WriteLine(_nameUnit + " has been defeated!!");

            }

        }
        public void Heal()
        {
            double rng = _random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(_healPower* rng);
           _currentHP = _currentHP + heal > _maxHP ? _maxHP : heal + _currentHP;
            Console.WriteLine(_nameUnit +  " Heals " + heal );


        }
    }
}
