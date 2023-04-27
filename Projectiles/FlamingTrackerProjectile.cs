using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace SummonerTrackerGun.Projectiles
{
    public class FlamingTrackerProjectile : TrackerProjectile
    {
		public override void AddLight()
		{
			//Add red glow
			Lighting.AddLight(Projectile.position, 0.5f, 0f, 0f);
		}
		public override void AddDebuffOnHit(NPC target)
        {
			Random rnd = new Random();
			target.AddBuff(BuffID.OnFire, rnd.Next(5,10)*60); // add on fire for 5-10 seconds
		}
	}
}
