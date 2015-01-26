using System;
using TrueCraft.API.Logic;
using TrueCraft.API;

namespace TrueCraft.Core.Logic.Items
{
    public class DiamondBootsItem : ArmourItem
    {
        public static readonly short ItemID = 0x139;

        public override short ID { get { return 0x139; } }

        public override ArmourMaterial Material { get { return ArmourMaterial.Diamond; } }

        public override short BaseDurability { get { return 320; } }

        public override float BaseArmour { get { return 1.5f; } }

        public override string DisplayName { get { return "Diamond Boots"; } }
    }
}