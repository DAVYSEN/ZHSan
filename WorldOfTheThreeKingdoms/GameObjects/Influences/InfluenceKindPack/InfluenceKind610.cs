﻿using GameObjects;
using GameObjects.Influences;
using System;


using System.Runtime.Serialization;namespace GameObjects.Influences.InfluenceKindPack
{

    [DataContract]public class InfluenceKind610 : InfluenceKind
    {

        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.BaseNoAccidentalInjury = true;
        }

        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.BaseNoAccidentalInjury = false;
        }
    }
}

