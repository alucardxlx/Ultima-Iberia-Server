/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;
namespace Server.Items
{
	public class PlasterCityMarketAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return null;
			}
		}

		[ Constructable ]
		public PlasterCityMarketAddon()
		{
            XmlAttach.AttachTo(this, new XmlCitySiege(10000, 60, 60, 1, 1, 5)); //<-------new CitySiege Attachment
			AddComponent( new AddonComponent( 1237 ), -2, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, 2, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, 2, 30 );
			AddComponent( new AddonComponent( 1236 ), -2, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, -1, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, -1, 30 );
			AddComponent( new AddonComponent( 99 ), 2, 4, 0 );
			AddComponent( new AddonComponent( 1240 ), 2, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, 4, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, 4, 36 );
			AddComponent( new AddonComponent( 1237 ), 3, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, 0, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, 0, 33 );
			AddComponent( new AddonComponent( 10075 ), 3, 0, 27 );
			AddComponent( new AddonComponent( 1236 ), 3, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, -1, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, -1, 33 );
			AddComponent( new AddonComponent( 1238 ), 3, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, 2, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, 2, 33 );
			AddComponent( new AddonComponent( 10075 ), 3, 2, 27 );
			AddComponent( new AddonComponent( 1239 ), 3, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, 1, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, 1, 33 );
			AddComponent( new AddonComponent( 100 ), 5, 2, 0 );
			AddComponent( new AddonComponent( 1244 ), 5, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, 2, 27 );
			AddComponent( new AddonComponent( 10074 ), 5, 2, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, 2, 27 );
			AddComponent( new AddonComponent( 100 ), 5, 1, 0 );
			AddComponent( new AddonComponent( 1244 ), 5, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, 1, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, 1, 27 );
			AddComponent( new AddonComponent( 100 ), 5, 0, 0 );
			AddComponent( new AddonComponent( 1244 ), 5, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, 0, 27 );
			AddComponent( new AddonComponent( 10074 ), 5, 0, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, 0, 27 );
			AddComponent( new AddonComponent( 1831 ), 5, 5, 0 );
			AddComponent( new AddonComponent( 101 ), 5, 4, 0 );
			AddComponent( new AddonComponent( 1248 ), 5, 4, 7 );
			AddComponent( new AddonComponent( 332 ), 5, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, 4, 27 );
			AddComponent( new AddonComponent( 10074 ), 5, 4, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, 4, 27 );
			AddComponent( new AddonComponent( 100 ), 5, 3, 0 );
			AddComponent( new AddonComponent( 1244 ), 5, 3, 7 );
			AddComponent( new AddonComponent( 298 ), 5, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, 3, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, 3, 27 );
			AddComponent( new AddonComponent( 1 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 1238 ), 0, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, -1, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, -1, 36 );
			AddComponent( new AddonComponent( 5139 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 1245 ), -3, 1, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, 1, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, 1, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, 1, 27 );
			AddComponent( new AddonComponent( 1245 ), -3, 0, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, 0, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, 0, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, 0, 27 );
			AddComponent( new AddonComponent( 1245 ), -3, -1, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, -1, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, -1, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, -1, 27 );
			AddComponent( new AddonComponent( 100 ), 5, -2, 0 );
			AddComponent( new AddonComponent( 1244 ), 5, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, -2, 27 );
			AddComponent( new AddonComponent( 10074 ), 5, -2, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, -2, 27 );
			AddComponent( new AddonComponent( 100 ), 5, -3, 0 );
			AddComponent( new AddonComponent( 1244 ), 5, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, -3, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, -3, 27 );
			AddComponent( new AddonComponent( 100 ), 5, -4, 0 );
			AddComponent( new AddonComponent( 1249 ), 5, -4, 7 );
			AddComponent( new AddonComponent( 334 ), 5, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, -4, 27 );
			AddComponent( new AddonComponent( 10074 ), 5, -4, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, -4, 27 );
			AddComponent( new AddonComponent( 99 ), 5, -5, 0 );
			AddComponent( new AddonComponent( 336 ), 5, -5, 7 );
			AddComponent( new AddonComponent( 1238 ), 4, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, 3, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, 3, 30 );
			AddComponent( new AddonComponent( 99 ), 4, 4, 0 );
			AddComponent( new AddonComponent( 1240 ), 4, 4, 7 );
			AddComponent( new AddonComponent( 298 ), 4, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, 4, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, 4, 30 );
			AddComponent( new AddonComponent( 1826 ), 4, 5, 0 );
			AddComponent( new AddonComponent( 1826 ), 3, 5, 0 );
			AddComponent( new AddonComponent( 99 ), -1, 4, 0 );
			AddComponent( new AddonComponent( 1240 ), -1, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, 4, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, 4, 33 );
			AddComponent( new AddonComponent( 99 ), 0, 4, 0 );
			AddComponent( new AddonComponent( 1240 ), 0, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, 4, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, 4, 36 );
			AddComponent( new AddonComponent( 1238 ), 1, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, 0, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, 0, 39 );
			AddComponent( new AddonComponent( 10076 ), 1, 0, 27 );
			AddComponent( new AddonComponent( 1826 ), -1, 5, 0 );
			AddComponent( new AddonComponent( 1237 ), 1, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, -2, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, -2, 39 );
			AddComponent( new AddonComponent( 10076 ), 1, -2, 27 );
			AddComponent( new AddonComponent( 1236 ), 1, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, -3, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, -3, 39 );
			AddComponent( new AddonComponent( 1241 ), 1, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, -4, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, -4, 39 );
			AddComponent( new AddonComponent( 10076 ), 1, -4, 27 );
			AddComponent( new AddonComponent( 99 ), 1, -5, 0 );
			AddComponent( new AddonComponent( 99 ), 0, -5, 0 );
			AddComponent( new AddonComponent( 1241 ), 0, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, -4, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, -4, 36 );
			AddComponent( new AddonComponent( 1237 ), 0, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, -3, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, -3, 36 );
			AddComponent( new AddonComponent( 1241 ), -2, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, -4, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, -4, 30 );
			AddComponent( new AddonComponent( 1826 ), 2, 5, 0 );
			AddComponent( new AddonComponent( 1238 ), -1, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, -1, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, -1, 33 );
			AddComponent( new AddonComponent( 1236 ), 0, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, 1, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, 1, 36 );
			AddComponent( new AddonComponent( 1238 ), -1, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, 1, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, 1, 33 );
			AddComponent( new AddonComponent( 1236 ), 1, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, 2, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, 2, 39 );
			AddComponent( new AddonComponent( 10076 ), 1, 2, 27 );
			AddComponent( new AddonComponent( 1237 ), 2, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, 2, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, 2, 36 );
			AddComponent( new AddonComponent( 99 ), -3, 4, 0 );
			AddComponent( new AddonComponent( 1246 ), -3, 4, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, 4, 24 );
			AddComponent( new AddonComponent( 336 ), -3, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), -3, 4, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, 4, 27 );
			AddComponent( new AddonComponent( 1239 ), 2, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, 0, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, 0, 36 );
			AddComponent( new AddonComponent( 100 ), -4, 3, 0 );
			AddComponent( new AddonComponent( 298 ), -4, 3, 7 );
			AddComponent( new AddonComponent( 100 ), -4, 4, 0 );
			AddComponent( new AddonComponent( 334 ), -4, 4, 7 );
			AddComponent( new AddonComponent( 10074 ), -4, 4, 27 );
			//AddComponent( new AddonComponent( 3026 ), -4, 5, 7 );
			//AddComponent( new AddonComponent( 2970 ), -3, 5, 2 );
			AddComponent( new AddonComponent( 2970 ), -4, 5, 7 );
			AddComponent( new AddonComponent( 1236 ), 3, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, -3, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, -3, 33 );
			AddComponent( new AddonComponent( 1245 ), -3, -2, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, -2, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, -2, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, -2, 27 );
			AddComponent( new AddonComponent( 1245 ), -3, -3, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, -3, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, -3, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, -3, 27 );
			AddComponent( new AddonComponent( 1247 ), -3, -4, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, -4, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, -4, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, -4, 27 );
			AddComponent( new AddonComponent( 100 ), -4, 2, 0 );
			AddComponent( new AddonComponent( 10074 ), -4, 2, 27 );
			AddComponent( new AddonComponent( 102 ), -4, -5, 0 );
			AddComponent( new AddonComponent( 298 ), -4, -5, 7 );
			AddComponent( new AddonComponent( 1826 ), 1, 5, 0 );
			AddComponent( new AddonComponent( 1238 ), 2, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, 3, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, 3, 36 );
			AddComponent( new AddonComponent( 1237 ), 1, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, 3, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, 3, 39 );
			AddComponent( new AddonComponent( 1826 ), -2, 5, 0 );
			AddComponent( new AddonComponent( 1237 ), -1, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, 3, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, 3, 33 );
			AddComponent( new AddonComponent( 1826 ), 0, 5, 0 );
			AddComponent( new AddonComponent( 99 ), -2, 4, 0 );
			AddComponent( new AddonComponent( 1240 ), -2, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, 4, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, 4, 30 );
			AddComponent( new AddonComponent( 10075 ), -2, 4, 27 );
			AddComponent( new AddonComponent( 99 ), 4, -5, 0 );
			AddComponent( new AddonComponent( 298 ), 4, -5, 7 );
			AddComponent( new AddonComponent( 1241 ), 4, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, -4, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, -4, 30 );
			AddComponent( new AddonComponent( 1237 ), 4, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, -3, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, -3, 30 );
			AddComponent( new AddonComponent( 100 ), 5, -1, 0 );
			AddComponent( new AddonComponent( 1244 ), 5, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), 5, -1, 27 );
			AddComponent( new AddonComponent( 11301 ), 5, -1, 27 );
			AddComponent( new AddonComponent( 1241 ), -1, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, -4, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, -4, 33 );
			AddComponent( new AddonComponent( 10075 ), -1, -4, 27 );
			AddComponent( new AddonComponent( 99 ), -1, -5, 0 );
			AddComponent( new AddonComponent( 1238 ), -1, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, -2, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, -2, 33 );
			AddComponent( new AddonComponent( 10075 ), -1, -2, 27 );
			AddComponent( new AddonComponent( 1239 ), 0, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, -2, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, -2, 36 );
			AddComponent( new AddonComponent( 1236 ), -1, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, 0, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, 0, 33 );
			AddComponent( new AddonComponent( 10075 ), -1, 0, 27 );
			AddComponent( new AddonComponent( 100 ), -4, -4, 0 );
			AddComponent( new AddonComponent( 334 ), -4, -4, 7 );
			AddComponent( new AddonComponent( 10074 ), -4, -4, 27 );
			AddComponent( new AddonComponent( 100 ), -4, -3, 0 );
			AddComponent( new AddonComponent( 1237 ), -2, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, 0, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, 0, 30 );
			AddComponent( new AddonComponent( 1237 ), 4, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, -1, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, -1, 30 );
			AddComponent( new AddonComponent( 1236 ), 4, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, 0, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, 0, 30 );
			AddComponent( new AddonComponent( 1237 ), 4, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, 1, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, 1, 30 );
			AddComponent( new AddonComponent( 1239 ), 4, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, 2, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, 2, 30 );
			AddComponent( new AddonComponent( 99 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 1240 ), 3, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, 4, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, 4, 33 );
			AddComponent( new AddonComponent( 10075 ), 3, 4, 27 );
			AddComponent( new AddonComponent( 1237 ), 3, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, 3, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, 3, 33 );
			AddComponent( new AddonComponent( 1236 ), -1, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, 2, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, 2, 33 );
			AddComponent( new AddonComponent( 10075 ), -1, 2, 27 );
			AddComponent( new AddonComponent( 100 ), -4, -2, 0 );
			AddComponent( new AddonComponent( 10074 ), -4, -2, 27 );
			AddComponent( new AddonComponent( 1236 ), 0, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, 3, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, 3, 36 );
			AddComponent( new AddonComponent( 1238 ), 1, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, 1, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, 1, 39 );
			AddComponent( new AddonComponent( 1237 ), 2, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, -1, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, -1, 36 );
			AddComponent( new AddonComponent( 1239 ), 1, -1, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, -1, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, -1, 39 );
			AddComponent( new AddonComponent( 1237 ), 2, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, -3, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, -3, 36 );
			AddComponent( new AddonComponent( 1236 ), 2, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, -2, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, -2, 36 );
			AddComponent( new AddonComponent( 99 ), 2, -5, 0 );
			AddComponent( new AddonComponent( 1241 ), 2, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, -4, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, -4, 36 );
			AddComponent( new AddonComponent( 1238 ), -2, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, -3, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, -3, 30 );
			AddComponent( new AddonComponent( 1238 ), -2, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, -2, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, -2, 30 );
			AddComponent( new AddonComponent( 99 ), -2, -5, 0 );
			AddComponent( new AddonComponent( 99 ), -3, -5, 0 );
			AddComponent( new AddonComponent( 336 ), -3, -5, 7 );
			AddComponent( new AddonComponent( 1236 ), -2, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, 1, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, 1, 30 );
			AddComponent( new AddonComponent( 1237 ), 0, 0, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, 0, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, 0, 36 );
			AddComponent( new AddonComponent( 99 ), 1, 4, 0 );
			AddComponent( new AddonComponent( 1240 ), 1, 4, 7 );
			AddComponent( new AddonComponent( 1190 ), 1, 4, 27 );
			AddComponent( new AddonComponent( 11300 ), 1, 4, 39 );
			AddComponent( new AddonComponent( 10076 ), 1, 4, 27 );
			AddComponent( new AddonComponent( 1237 ), 0, 2, 7 );
			AddComponent( new AddonComponent( 1190 ), 0, 2, 27 );
			AddComponent( new AddonComponent( 11302 ), 0, 2, 36 );
			AddComponent( new AddonComponent( 1238 ), 2, 1, 7 );
			AddComponent( new AddonComponent( 1190 ), 2, 1, 27 );
			AddComponent( new AddonComponent( 11301 ), 2, 1, 36 );
			AddComponent( new AddonComponent( 1833 ), -3, 5, 0 );
			AddComponent( new AddonComponent( 1239 ), -2, 3, 7 );
			AddComponent( new AddonComponent( 1190 ), -2, 3, 27 );
			AddComponent( new AddonComponent( 11302 ), -2, 3, 30 );
			AddComponent( new AddonComponent( 1245 ), -3, 3, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, 3, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, 3, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, 3, 27 );
			AddComponent( new AddonComponent( 1241 ), 3, -4, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, -4, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, -4, 33 );
			AddComponent( new AddonComponent( 10075 ), 3, -4, 27 );
			AddComponent( new AddonComponent( 99 ), 3, -5, 0 );
			AddComponent( new AddonComponent( 1238 ), 3, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), 3, -2, 27 );
			AddComponent( new AddonComponent( 11301 ), 3, -2, 33 );
			AddComponent( new AddonComponent( 10075 ), 3, -2, 27 );
			AddComponent( new AddonComponent( 1236 ), 4, -2, 7 );
			AddComponent( new AddonComponent( 1190 ), 4, -2, 27 );
			AddComponent( new AddonComponent( 11301 ), 4, -2, 30 );
			AddComponent( new AddonComponent( 100 ), -4, -1, 0 );
			AddComponent( new AddonComponent( 100 ), -4, 0, 0 );
			AddComponent( new AddonComponent( 10074 ), -4, 0, 27 );
			AddComponent( new AddonComponent( 100 ), -4, 1, 0 );
			AddComponent( new AddonComponent( 1239 ), -1, -3, 7 );
			AddComponent( new AddonComponent( 1190 ), -1, -3, 27 );
			AddComponent( new AddonComponent( 11302 ), -1, -3, 33 );
			AddComponent( new AddonComponent( 1245 ), -3, 2, 7 );
			AddComponent( new AddonComponent( 11302 ), -3, 2, 24 );
			AddComponent( new AddonComponent( 1190 ), -3, 2, 27 );
			AddComponent( new AddonComponent( 11302 ), -3, 2, 27 );
			AddonComponent ac;
			ac = new AddonComponent( 2970 );
			AddComponent( ac, -4, 5, 7 );

		}

		public PlasterCityMarketAddon( Serial serial ) : base( serial )
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
