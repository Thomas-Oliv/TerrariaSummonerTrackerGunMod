using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SummonerTrackerGun.Projectiles
{
    public class TrackerProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tracker Bullet"); 
		}
		public override void SetDefaults()
		{
			Projectile.DamageType = DamageClass.Summon;
			Projectile.width = 4;
			Projectile.height = 20;
			Projectile.aiStyle = 1;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.penetrate = 1;
			Projectile.timeLeft = 400;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = true;
			Projectile.scale = 0.7f;
			Projectile.extraUpdates = 1;
		}

		public virtual void AddLight()
        {
			//Add orange glow
			Lighting.AddLight(Projectile.position, 1f, 0.7f, 0.1f);
		}

		public override void AI()
		{
			// clear style
			Projectile.aiStyle = 0;
			//make projectile glow a certain color
			AddLight();
			Lighting.Brightness(1, 1);
		}

		public override void Kill(int timeLeft)
		{
			SoundEngine.PlaySound(SoundID.Dig.WithVolumeScale(0.5f).WithPitchOffset(0.8f), Projectile.position);
			for (var i = 0; i < 6; i++)
			{
				Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
		}

		//Allow us to add debuf on hit to sub-classes
		public virtual void AddDebuffOnHit(NPC target) { }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			//Apply minion targetting to non-friendly npcs
			if (!target.friendly)
			{
				Main.player[Projectile.owner].MinionAttackTargetNPC = target.whoAmI;
				AddDebuffOnHit(target);
			}

			SoundEngine.PlaySound(SoundID.Item10, new Vector2(Projectile.position.X, Projectile.position.Y));
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			SoundEngine.PlaySound(SoundID.Dig.WithVolumeScale(0.5f).WithPitchOffset(0.8f), Projectile.position);
			return true;
		}
	}
}
