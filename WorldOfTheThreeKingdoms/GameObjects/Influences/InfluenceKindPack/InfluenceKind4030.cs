﻿using GameObjects;
using GameObjects.Influences;
using System;


using System.Runtime.Serialization;namespace GameObjects.Influences.InfluenceKindPack
{

    [DataContract]public class InfluenceKind4030 : InfluenceKind
    {
        public override void ApplyInfluenceKind(Person person)
        {
            if (person.LocationTroop != null)
            {
                person.LocationTroop.StuntCanAttackAfterRout = true;
            }
        }

        public override void PurifyInfluenceKind(Person person)
        {
            if (person.LocationTroop != null)
            {
                person.LocationTroop.StuntCanAttackAfterRout = false;
            }
        }
    }
}

