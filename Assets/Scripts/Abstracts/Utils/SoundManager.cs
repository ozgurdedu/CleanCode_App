using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cleancode_App.Abstracts.Utils;

public class SoundManager : Singleton<SoundManager>
{
    private void Awake()
    {
        SingletonFunction(this);
    }
    
    
}
