﻿using Match3.Foundation.Base.Configuration;
using UnityEngine;

namespace Match3.Foundation.Unity.Configuration
{
    public abstract class ScriptableConfiguration : ScriptableObject, Configurer
    {
        public abstract void RegisterSelf(ConfigurationManager manager);


        // TODO: Move this to a better place.
        public T[] ShallowCopy<T>(T[] array) where T : ScriptableObject
        {
            var coppies = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
                coppies[i] = Instantiate(array[i]);

            return coppies;
        }
    }
}