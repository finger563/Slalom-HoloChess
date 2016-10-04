﻿using DejarikLibrary;
using UnityEngine;

namespace Assets.Scripts.Monsters
{
    public abstract class Monster : MonoBehaviour
    {
        public abstract int AttackRating { get; }
        public abstract int DefenseRating { get; }
        public abstract int MovementRating { get; }

        public Node CurrentNode { get; set; }

        void Start()
        {
        }

        void Update()
        {
        }
    }
}
