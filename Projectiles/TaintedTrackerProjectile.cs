using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace SummonerTrackerGun.Projectiles
{
    public class TaintedTrackerProjectile : TrackerProjectile
    {
		public override void AddDebuffOnHit(NPC target)
        {
			Random rnd = new Random();
			target.AddBuff(BuffID.Ichor, rnd.Next(6, 12)*60); // add ichor debuff for 6-12 seconds
		}

		public override void AddLight()
		{
			//Add yellow glow
			Lighting.AddLight(Projectile.position, 0.9f, 0.9f, 0f);
		}
	}
}
