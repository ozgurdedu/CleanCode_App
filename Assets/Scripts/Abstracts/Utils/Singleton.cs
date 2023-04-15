using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cleancode_App.Abstracts.Utils
{
    public abstract class Singleton<T> : MonoBehaviour // tipi belli olmayan bir T objesi tanımladık
    {

        public static T Instance { get; private set; }

        // sadece miras verdiği sınıflardan erişsin diye
        // PROTECTED olarak tanımladık.
        
        protected void SingletonFunction(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        // artık.. 
        // miras verdiği sınıf, AWAKE fonksiyonunda
        // SingletonFunction() fonksiyonunu kullanarak 
        // SINGLETON yapıya erişmiş olacak.
        
        
        
    }
}
