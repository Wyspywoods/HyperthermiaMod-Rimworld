using RimWorld;
using System;

namespace Hyperthermia
{
    public class MapCondition_HeatWave : MapCondition
    {
        private const int LerpTicks = 12000;

        private const float MaxTempOffset = 30f;

        public override float TemperatureOffset()
        {
            return MapConditionUtility.LerpInOutValue((float)base.TicksPassed, (float)base.TicksLeft, 12000f, 30f);
        }
    }
}
