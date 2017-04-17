using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class NewBehaviourScript : Editor
{

   // [MenuItem(new Script,"New c# script" )]
    public static void Nothing()
    {
        MonoScript script = new MonoScript();
         AssetDatabase.CreateAsset(script ,(@"C: /Users/svc - student/Desktop/NodeExample - master/Assets"));
        
    }

}


