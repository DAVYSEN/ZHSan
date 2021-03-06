﻿using GameObjects;
using System;


using System.Runtime.Serialization;namespace GameObjects.ArchitectureDetail.EventEffect
{

    [DataContract]public class EventEffect10 : EventEffectKind
    {
        private int increment;

        public override void ApplyEffectKind(Person person, Event e)
        {
            person.BaseCommand += increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

