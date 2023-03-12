using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Const : MonoBehaviour
{
    public static class Map
    {
        public static readonly float x = 26f;
        public static readonly float y = 14f;
        public static readonly float moveSpeed = 100f;
        public static readonly float existenceTimeItem = 5f;
    }

    public static class Item
    {
        public static class Heal
        {
            public static readonly float existenceTimeOnPlayer = 5f;
            public static readonly float spawnRate = 0.3f;
            public static readonly float healBuff = 0.3f;
        }
        public static class Ghost
        {
            public static readonly float existenceTimeOnPlayer = 5f;
            public static readonly float spawnRate = 0.3f;
            public static readonly float speedBuff = 0.3f;
        }
        public static class Shield
        {
            public static readonly float existenceTimeOnPlayer = 5f;
            public static readonly float spawnRate = 0.3f;
        }
    }
}
