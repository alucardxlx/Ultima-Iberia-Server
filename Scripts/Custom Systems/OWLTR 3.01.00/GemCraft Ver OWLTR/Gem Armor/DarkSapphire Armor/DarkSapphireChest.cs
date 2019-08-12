using System;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x2641, 0x2642 )]
	public class DarkSapphireChest : BaseArmor
	{

		public override int BaseColdResistance{ get{ return 8; } }

		public override int InitMinHits{ get{ return 155; } }
		public override int InitMaxHits{ get{ return 205; } }

		public override int AosStrReq{ get{ return 75; } }
		public override int OldStrReq{ get{ return 60; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Dragon; } }

		[Constructable]
		public DarkSapphireChest() : base( 0x2641 )
		{
            Name = "DarkSapphire Chest";
            Hue = 1176;
			Weight = 10.0;

            Attributes.BonusDex = Utility.RandomMinMax(2, 5);
            Attributes.BonusHits = Utility.RandomMinMax(3, 7);
            Attributes.DefendChance = Utility.RandomMinMax(3, 8);
            Attributes.LowerManaCost = Utility.RandomMinMax(8, 20);
            Attributes.NightSight = 1;
            Attributes.Luck = Utility.RandomMinMax(100, 250);
            Attributes.ReflectPhysical = Utility.RandomMinMax(5, 15);
            Attributes.RegenStam = Utility.RandomMinMax(3, 7);
            ArmorAttributes.SelfRepair = 3;

            ColdBonus = Utility.RandomMinMax(9, 15);
            FireBonus = Utility.RandomMinMax(2, 10);
		}

        public DarkSapphireChest(Serial serial)
            : base(serial)
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Weight == 1.0 )
				Weight = 15.0;
		}
	}
}