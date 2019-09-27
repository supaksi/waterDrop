using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; // 이거 추가해야 합니다.

[CustomEditor(typeof(ValveGenerator))]
public class ValveGeneratorEditor : Editor // Editor Class를 상속(inheritace)한다
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ValveGenerator myscript = (ValveGenerator)target; //target을 ValveGenerator로 Type Casting을 myscript로 지정
        if(GUILayout.Button("Bulid Model")){
            myscript.BuildValves();
        }
    }
}
