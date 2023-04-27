using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace SummonerTrackerGun.Projectiles
{
    public class CursedTrackerProjectile : TrackerProjectile
    {
		public override void AddDebuffOnHit(NPC target)
        {
			Random rnd = new Random();
			target.AddBuff(BuffID.CursedInferno, rnd.Next(6, 12)*60); // add cursed inferno for 6-12 seconds
		}

		public override void AddLight()
		{
			//Add light green glow
			Lighting.AddLight(Projectile.position, 0f, 0.9f, 0f);
		}
	}
}
