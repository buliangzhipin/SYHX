﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContent : Assitant<CardSource>
{
    public CardContent(CardSource owner) : base(owner) { }
    public CardType cardType { get; private set; }
    public int EP { get; private set; }
    public void OnDraw() => owner.OnDraw();
    public void OnUse() => owner.OnUse();
    public void OnFold() => owner.OnFold();
    public void OnExiled() => owner.OnExiled();
    public void OnOtherCardUse(CardSource context) => owner.OnOtherCardUse(context);
}