/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;
namespace Server.Items
{
	public class StoneCityStableAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				//return new StoneCityStableAddonDeed();
				return null;
			}
		}

		[ Constructable ]
		public StoneCityStableAddon()
		{
   XmlAttach.AttachTo(this, new XmlCitySiege(5000,60,60,1,1,5)); //<-------new CitySiege Attachment
			AddonComponent ac = null;
			ac = new AddonComponent( 464 );
			AddComponent( ac, 5, -5, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 3, -5, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 2, -5, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 1, -5, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 0, -5, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -1, -5, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -3, -5, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -4, 1, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -4, 0, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -4, -2, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -4, -4, 7 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, -4, -5, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 5, 2, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 5, 1, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 5, 0, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 5, -1, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, -2, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 5, -3, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 4, 2, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 4, 1, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, -1, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, -2, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 4, -3, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 4, -4, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 3, 2, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 3, 1, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 3, 0, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 3, -1, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, -2, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 3, -4, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 2, 2, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 2, 1, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, 0, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 2, -1, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 2, -2, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 2, -3, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 2, -4, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 1, -1, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, -3, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 1, -4, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 0, 2, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 1, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -1, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 0, -2, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -3, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 0, -4, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, -1, 2, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, -1, 0, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -1, -1, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, -1, -2, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -1, -4, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, 2, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, -2, 1, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, -2, 0, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, -1, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, -2, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -2, -3, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -2, -4, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, 2, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, -3, 1, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -3, 0, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, -1, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -3, -4, 7 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 5, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 3, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 2, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -2, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -3, -5, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -3, 0 );
			ac = new AddonComponent( 102 );
			AddComponent( ac, -4, -5, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -2, -5, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -4, -3, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 5, -4, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 3, -3, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 1, 2, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, -1, -3, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, -3, -2, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -3, -3, 7 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, 2, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, 0, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, -1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, -2, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, -3, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, -4, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 4, -5, 7 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -4, 2, 7 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -4, -1, 7 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 5, 0, 7 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 5, -3, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 5, 2, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 5, 1, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 5, -1, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 5, -2, 7 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 5, -4, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 4, 0, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 1, 1, 7 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, 1, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, -4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 4, -5, 0 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, -4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, -3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, -2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, -1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, 0, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, 1, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, 2, 27 );
			ac = new AddonComponent( 17 );
			AddComponent( ac, -1, -4, 7 );
			ac = new AddonComponent( 17 );
			AddComponent( ac, 1, -4, 7 );
			ac = new AddonComponent( 17 );
			AddComponent( ac, -1, -3, 7 );
			ac = new AddonComponent( 17 );
			AddComponent( ac, 1, -3, 7 );
			ac = new AddonComponent( 17 );
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 17 );
			AddComponent( ac, -1, -2, 7 );
			ac = new AddonComponent( 18 );
			AddComponent( ac, 2, -2, 7 );
			ac = new AddonComponent( 18 );
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 18 );
			AddComponent( ac, -1, -2, 7 );
			ac = new AddonComponent( 18 );
			AddComponent( ac, -3, -2, 7 );
			ac = new AddonComponent( 18 );
			AddComponent( ac, 4, -2, 7 );
			ac = new AddonComponent( 2877 );
			AddComponent( ac, -3, 2, 7 );
			ac = new AddonComponent( 2879 );
			AddComponent( ac, -3, 1, 7 );
			ac = new AddonComponent( 4977 );
			AddComponent( ac, -3, 2, 13 );
			ac = new AddonComponent( 4979 );
			AddComponent( ac, -3, 1, 13 );
			ac = new AddonComponent( 3893 );
			AddComponent( ac, 2, -2, 7 );
			ac = new AddonComponent( 3893 );
			AddComponent( ac, 0, -4, 7 );
			ac = new AddonComponent( 3893 );
			AddComponent( ac, -3, -2, 7 );
			ac = new AddonComponent( 3893 );
			AddComponent( ac, 3, 0, 7 );
			ac = new AddonComponent( 3893 );
			AddComponent( ac, -1, 2, 7 );
			ac = new AddonComponent( 3893 );
			AddComponent( ac, 2, 2, 7 );
			ac = new AddonComponent( 4109 );
			AddComponent( ac, 3, -4, 7 );
			ac = new AddonComponent( 4109 );
			AddComponent( ac, -2, -4, 7 );
			ac = new AddonComponent( 6802 );
			AddComponent( ac, 0, -3, 7 );
			ac = new AddonComponent( 5453 );
			AddComponent( ac, -3, -4, 7 );
			ac = new AddonComponent( 5453 );
			AddComponent( ac, 2, -4, 7 );
			ac = new AddonComponent( 5453 );
			AddComponent( ac, 0, -4, 7 );
			ac = new AddonComponent( 3896 );
			AddComponent( ac, -3, 0, 7 );
			ac = new AddonComponent( 2581 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -3, 2, 13 );
			ac = new AddonComponent( 491 );
			AddComponent( ac, -4, -5, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, -4, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, -3, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, -2, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, -1, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, 0, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, 1, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, 2, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, -3, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, -2, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, -1, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 0, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 1, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 2, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 3, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 4, -5, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 5, -5, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, -4, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, -3, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, -2, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, -1, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, 0, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, 1, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, 2, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, 4, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 5, 3, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 4, 4, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, 4, 3, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, 4, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 3, 3, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 2, 4, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 2, 3, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 0, 4, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 3, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, 4, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, -1, 3, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, -3, 3, 7 );
			ac = new AddonComponent( 101 );
			AddComponent( ac, 5, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 4, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -4, 4, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, 1, 4, 7 );
			ac = new AddonComponent( 1308 );
			AddComponent( ac, 1, 3, 7 );
			ac = new AddonComponent( 1306 );
			AddComponent( ac, -2, 4, 7 );
			ac = new AddonComponent( 1307 );
			AddComponent( ac, -2, 3, 7 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, 4, 7 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, 5, 3, 0 );
			ac = new AddonComponent( 1873 );
			AddComponent( ac, 4, 5, 0 );
			ac = new AddonComponent( 1873 );
			AddComponent( ac, 3, 5, 0 );
			ac = new AddonComponent( 99 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 100 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -4, 3, 7 );
			ac = new AddonComponent( 10662 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, 4, 7 );
			ac = new AddonComponent( 10662 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -2, 4, 7 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 5, 3, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 2, 4, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 0, 4, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -1, 4, 7 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -3, 4, 7 );
			ac = new AddonComponent( 463 );
			AddComponent( ac, 5, 4, 7 );
			ac = new AddonComponent( 1882 );
			AddComponent( ac, 5, 5, 0 );
			ac = new AddonComponent( 1883 );
			AddComponent( ac, 2, 5, 0 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -3, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -2, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, -1, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 2, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 3, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 4, 4, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, 3, 27 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 5, 4, 27 );
			ac = new AddonComponent( 2879 );
			AddComponent( ac, -3, 3, 7 );
			ac = new AddonComponent( 4981 );
			AddComponent( ac, -3, 3, 17 );
			ac = new AddonComponent( 2974 );
			AddComponent( ac, -4, 5, 7 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, 3, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -4, 4, 27 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, 5, 3, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, -3, 4, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, -2, 4, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, -1, 4, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 0, 4, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 1, 4, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 2, 4, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 3, 4, 27 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, 4, 4, 27 );
			ac = new AddonComponent( 488 );
			AddComponent( ac, 5, 4, 27 );

		}

		public StoneCityStableAddon( Serial serial ) : base( serial )
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


}
