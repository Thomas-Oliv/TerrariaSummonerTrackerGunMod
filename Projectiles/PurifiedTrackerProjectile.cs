using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace SummonerTrackerGun.Projectiles
{
    public class PurifiedTrackerProjectile : TrackerProjectile
    {
		public override void AddDebuffOnHit(NPC target)
        {
			Random rnd = new Random();
			target.AddBuff(BuffID.BetsysCurse, rnd.Next(7, 14)*60); // add betsy curse debuff for 7-14 seconds
		}

		public override void AddLight()
		{
			//Add light blue glow
			Lighting.AddLight(Projectile.position, 0f, 0.9f, 0.9f);
		}
	}
}
