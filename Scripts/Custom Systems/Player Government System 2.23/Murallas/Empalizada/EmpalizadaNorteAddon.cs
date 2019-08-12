
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

namespace Server.Items
{
	public class EmpalizadaNorteAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1220, 2, 0, 14}, {1220, 0, 0, 14}, {546, 1, -1, 14}// 1	2	3	
			, {1220, -1, 0, 14}, {546, 2, -1, 2}, {546, -1, -1, 14}// 4	5	6	
			, {1220, 1, 0, 14}, {546, -1, -1, 2}, {546, 1, -1, 2}// 7	8	9	
			, {546, 0, -1, 2} // 10	11	12	
			, {4014, 2, 0, 0}, {4014, 2, 0, 3}, {4014, 2, 0, 6}// 13	14	15	
			, {4014, 2, 0, 9}, {4014, -1, 0, 0}, {4014, -1, 0, 3}// 16	17	18	
			, {4014, -1, 0, 6}, {4014, -1, 0, 9}// 19	20	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EmpalizadaNorteAddonDeed();
			}
		}

		[ Constructable ]
		public EmpalizadaNorteAddon()
		{
  XmlAttach.AttachTo(this, new XmlCitySiege(2500,60,60,1,1,5)); //<-------new CitySiege Attachment

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public EmpalizadaNorteAddon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class EmpalizadaNorteAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EmpalizadaNorteAddon();
			}
		}

		[Constructable]
		public EmpalizadaNorteAddonDeed()
		{
			Name = "EmpalizadaNorte";
		}

		public EmpalizadaNorteAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}