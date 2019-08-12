
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
	public class EmpalizadaPuertaSurAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, -2, 1, 0}, {1848, -2, 1, 5}, {546, -2, 2, 0}// 1	2	3	
			, {1848, -2, 0, 0}, {2173, -2, -1, 0}, {2173, -2, 0, 5}// 4	5	6	
			, {1848, -3, 1, 0}, {1848, -3, 1, 5}, {546, -3, 2, 0}// 7	8	9	
			, {546, -2, 2, 5}, {2170, 2, 1, 10}, {1848, 2, 1, 5}// 10	11	12	
			, {1848, 2, 1, 0}, {1848, 3, 1, 0}, {2173, 3, 0, 5}// 13	14	15	
			, {546, -1, 0, 0}, {546, 4, 2, 0}, {546, 1, 2, 16}// 16	17	18	
			, {547, -1, 2, 0}, {1848, 3, 0, 0}, {545, 4, 2, 0}// 19	20	21	
			, {546, 2, 2, 10}, {1848, 3, 1, 0}, {1221, 1, 1, 16}// 22	23	24	
			, {1848, -1, 1, 0}, {1848, -1, 1, 5}, {546, 2, 0, 0}// 25	26	27	
			, {2172, -1, 1, 10}, {1848, 3, 1, 5}, {1221, 0, 1, 16}// 28	29	30	
			, {546, 2, 2, 0}, {2173, 3, -1, 0}, {546, 0, 2, 16}// 31	32	33	
			, {546, -1, 2, 10}, {545, 2, 0, 0}, {1848, 4, 1, 0}// 34	36	37	
			, {1848, 4, 1, 5}, {546, 3, 2, 0}, {546, 3, 2, 5}// 38	39	40	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EmpalizadaPuertaSurAddonDeed();
			}
		}

		[ Constructable ]
		public EmpalizadaPuertaSurAddon()
		{
						  XmlAttach.AttachTo(this, new XmlCitySiege(3500,60,60,1,1,5)); //<-------new CitySiege Attachment


            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			
			AddComplexComponent( (BaseAddon) this, 2572, 2, 3, 15, 0, 5, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2572, -1, 3, 15, 0, 5, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2567, 0, 1, 11, 0, 8, "", 1);// 38
		}

		public EmpalizadaPuertaSurAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class EmpalizadaPuertaSurAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EmpalizadaPuertaSurAddon();
			}
		}

		[Constructable]
		public EmpalizadaPuertaSurAddonDeed()
		{
			Name = "EmpalizadaPuertaSur";
		}

		public EmpalizadaPuertaSurAddonDeed( Serial serial ) : base( serial )
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