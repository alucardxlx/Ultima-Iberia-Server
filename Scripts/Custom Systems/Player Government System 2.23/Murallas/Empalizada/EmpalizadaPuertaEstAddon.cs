
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
	public class EmpalizadaPuertaEstAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1288, 1, 0, 16}, {1848, 1, -1, 5}, {1848, 1, -1, 0}// 1	2	3	
			, {547, 2, 4, 0}, {545, 2, 2, 0}, {1848, 1, 3, 5}// 4	5	6	
			, {2172, 0, -2, 5}, {545, 2, -2, 0}, {1848, 1, 3, 0}// 7	8	9	
			, {545, 2, -1, 12}, {545, 2, 3, 0}, {545, 2, 0, 20}// 10	11	12	
			, {545, 2, 3, 12}, {2172, -1, -2, 0}, {2173, 1, -1, 10}// 13	14	15	
			, {545, 2, 1, 20}, {1848, 1, -2, 0}, {1848, 0, 3, 0}// 16	17	18	
			, {2171, 1, 2, 10}, {545, 2, 2, 16}, {545, 2, -1, 0}// 19	20	21	
			, {1288, 1, 1, 16}, {2172, 0, 3, 5}, {545, 2, 2, 16}// 22	23	24	
			, {1848, 0, -2, 0}, {1848, 1, -2, 5}, {546, 2, 2, 0}// 25	26	27	
			, {2172, -1, 3, 0}, {547, 2, -1, 0}, {545, 2, -2, 6}// 28	29	30	
			, {1848, 1, -3, 0}, {1848, 1, -3, 5}, {1848, 1, 4, 0}// 31	32	33	
			, {1848, 1, 4, 5}, {545, 2, -3, 0}, {545, 2, 4, 7}// 34	35	36	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EmpalizadaPuertaEstAddonDeed();
			}
		}

		[ Constructable ]
		public EmpalizadaPuertaEstAddon()
		{
						  XmlAttach.AttachTo(this, new XmlCitySiege(3500,60,60,1,1,5)); //<-------new CitySiege Attachment


            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		
			AddComplexComponent( (BaseAddon) this, 2567, 3, -2, 15, 0, 8, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2572, 1, 0, 11, 0, 5, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2567, 3, 3, 15, 0, 8, "", 1);// 28

		}

		public EmpalizadaPuertaEstAddon( Serial serial ) : base( serial )
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

	public class EmpalizadaPuertaEstAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EmpalizadaPuertaEstAddon();
			}
		}

		[Constructable]
		public EmpalizadaPuertaEstAddonDeed()
		{
			Name = "EmpalizadaPuertaEst";
		}

		public EmpalizadaPuertaEstAddonDeed( Serial serial ) : base( serial )
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