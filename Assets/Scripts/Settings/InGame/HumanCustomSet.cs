﻿using Settings;
using UnityEngine;
using Characters;

namespace Settings
{
    class HumanCustomSet: BaseSetSetting
    {
        // costume
        public IntSetting Sex = new IntSetting(0);
        public IntSetting Eye = new IntSetting(0);
        public StringSetting Face = new StringSetting("FaceNone");
        public StringSetting Glass = new StringSetting("GlassNone");
        public StringSetting Hair = new StringSetting("HairM0");
        public IntSetting Skin = new IntSetting(0);
        public IntSetting Costume = new IntSetting(0);
        public IntSetting Cape = new IntSetting(0);
        public IntSetting Logo = new IntSetting(0);
        public ColorSetting HairColor = new ColorSetting();
        public ColorSetting ShirtColor = new ColorSetting();
        public ColorSetting StrapsColor = new ColorSetting();
		public ColorSetting PantsColor = new ColorSetting();
		public ColorSetting JacketColor = new ColorSetting();
		public ColorSetting BootsColor = new ColorSetting();		

        // stats
        public IntSetting Speed = new IntSetting(110, minValue: 100, maxValue: 150);
        public IntSetting Gas = new IntSetting(115, minValue: 100, maxValue: 150);
        public IntSetting Blade = new IntSetting(110, minValue: 100, maxValue: 150);
        public IntSetting Acceleration = new IntSetting(115, minValue: 100, maxValue: 150);

        protected override bool Validate()
        {
            if (Speed.Value + Gas.Value + Blade.Value + Acceleration.Value > 450)
                return false;
            if (Sex.Value == 0 && Costume.Value >= HumanSetup.CostumeMCount)
                return false;
            if (Sex.Value == 1 && Costume.Value >= HumanSetup.CostumeFCount)
                return false;
            return true;
        }
    }

    public enum HumanSex
    {
        Male,
        Female
    }
}
