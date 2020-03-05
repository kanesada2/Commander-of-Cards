using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public enum Phase
{
DRAW,
SELECT_ATTACKER,
SELECT_HAND,
USE,
BATTLE
}

[System.Serializable]
public class PhaseReactiveProperty : ReactiveProperty
{
public PhaseReactiveProperty() { }
public PhaseReactiveProperty(Phase initialValue) : base(initialValue) { }

}