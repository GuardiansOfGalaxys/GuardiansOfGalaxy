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
        public static readonly float existenceTimeItem = 20f;
        public static readonly string tilemapTop = "TilemapTop";
        public static readonly string tilemapMiddle = "TilemapMiddle";
        public static readonly string tilemapBottom = "TilemapBottom";
        public static readonly string tilemapLeft = "TilemapLeft";
        public static readonly string tilemapRight = "TilemapRight";
        public static readonly string tilemapTopLeft = "TilemapTopLeft";
        public static readonly string tilemapTopRight = "TilemapTopRight";
        public static readonly string tilemapBottomLeft = "TilemapBottomLeft";
        public static readonly string tilemapBottomRight = "TilemapBottomRight";
    }

    public static class Item
    {
        public static class Heal
        {
            public static readonly string name = "Heal";
           // public static readonly float spawnRate = 0.5f;
            public static readonly float healBuff = 0.3f;
        }
        public static class Ghost
        {
            public static readonly string name = "Ghost";
            public static readonly float existenceTimeOnPlayer = 5f;
            //public static readonly float spawnRate = 0.5f;
            public static readonly float speedBuff = 0.3f;
        }
    }
}
