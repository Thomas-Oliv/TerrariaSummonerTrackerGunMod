using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace SummonerTrackerGun.Projectiles
{
    public class LunarTrackerProjectile : TrackerProjectile
    {
		public override void AddDebuffOnHit(NPC target)
        {
			Random rnd = new Random();
			// Apply oiled and all other debuffs from previous iterations. Might be a little busted.
			target.AddBuff(BuffID.Oiled, rnd.Next(8, 16) * 60);

			target.AddBuff(BuffID.BetsysCurse, rnd.Next(8, 16)*60);
			target.AddBuff(BuffID.CursedInferno, rnd.Next(8, 16) * 60);
			target.AddBuff(BuffID.Ichor, rnd.Next(8, 16) * 60); 
			target.AddBuff(BuffID.OnFire, rnd.Next(8, 16) * 60);
			target.AddBuff(BuffID.Poisoned, rnd.Next(8, 16) * 60);
		}

		public override void AddLight()
		{
			//Add white glow
			Lighting.AddLight(Projectile.position, 1f, 1f, 1f);
		}
	}
}
