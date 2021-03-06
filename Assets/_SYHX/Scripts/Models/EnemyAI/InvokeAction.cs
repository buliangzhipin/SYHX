﻿using System;
using HutongGames.PlayMaker;

[ActionCategory("SYHX")]
[ActionTarget(typeof(EnemyAction), "action", false)]
[Tooltip("Action Invoker（激活敌方行动）")]
public class InvokeAction : FsmStateAction
{
    public EnemyAction action;
    private EnemyAIHandler handler;
    public override void Awake()
    {
        handler = Fsm.GameObject.GetComponent<EnemyAIHandler>();
    }
    public override void OnEnter()
    {
        if (action != null)
        {
            action.SetEnemy(handler.enemy);
            action.Execute();
        }
        Finish();
    }
}
