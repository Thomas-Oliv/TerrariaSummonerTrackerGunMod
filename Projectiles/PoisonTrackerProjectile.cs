using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace SummonerTrackerGun.Projectiles
{
    public class PoisonTrackerProjectile : TrackerProjectile
    {
		public override void AddDebuffOnHit(NPC target)
        {
			Random rnd = new Random();
			target.AddBuff(BuffID.Poisoned, rnd.Next(4, 8)*60); // add  poisoned for 4-8 seconds
		}

		public override void AddLight()
		{
			//Add green glow
			Lighting.AddLight(Projectile.position, 0f, 0.5f, 0f);
		}
	}
}
