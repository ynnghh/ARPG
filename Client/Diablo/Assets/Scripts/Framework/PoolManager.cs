﻿using UnityEngine;

namespace Framework
{
    public class PoolManager : Singleton<PoolManager>
    {
        // 从对象池获得一个GameObject
        public GameObject Get(string prefabPath)
        {
            return null;
        }

        // 将GameObject回收到对象池中
        public void Recycle(GameObject gameObject)
        {

        }

        // 进入游戏前，预先加载一定数量的对象，防止运行时卡顿
        public void Preload(string prefabPath, int count)
        {

        }

        public void OnUpdate(float deltaTime)
        {

        }
    }
}
