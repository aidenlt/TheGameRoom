using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGameRoom.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class OreZombie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ore Zombie");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 25;
			npc.defense = 6;
			npc.lifeMax = 300;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.8f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 50f;
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ItemID.IronOre, Main.rand.Next(1, 11));
			Item.NewItem(npc.getRect(), ItemID.CopperOre, Main.rand.Next(1, 12));
			Item.NewItem(npc.getRect(), ItemID.GoldOre, Main.rand.Next(1, 9));
			Item.NewItem(npc.getRect(), ItemID.SilverOre, Main.rand.Next(1, 10));
			Item.NewItem(npc.getRect(), ItemID.TinOre, Main.rand.Next(1, 12));
			Item.NewItem(npc.getRect(), ItemID.LeadOre, Main.rand.Next(1, 11));
			Item.NewItem(npc.getRect(), ItemID.TungstenOre, Main.rand.Next(1, 10));
			Item.NewItem(npc.getRect(), ItemID.PlatinumOre, Main.rand.Next(1, 9));
			Item.NewItem(npc.getRect(), ItemID.DemoniteOre, Main.rand.Next(1, 7));
			Item.NewItem(npc.getRect(), ItemID.CrimtaneOre, Main.rand.Next(1, 7));

			if (Main.hardMode)
			{

			Item.NewItem(npc.getRect(), ItemID.CobaltOre, Main.rand.Next(1, 4));
			Item.NewItem(npc.getRect(), ItemID.PalladiumOre, Main.rand.Next(1, 4));
			Item.NewItem(npc.getRect(), ItemID.MythrilOre, Main.rand.Next(1, 4));
			Item.NewItem(npc.getRect(), ItemID.OrichalcumOre, Main.rand.Next(1, 4));
			Item.NewItem(npc.getRect(), ItemID.AdamantiteOre, Main.rand.Next(1, 3));
			Item.NewItem(npc.getRect(), ItemID.TitaniumOre, Main.rand.Next(1, 3));
			Item.NewItem(npc.getRect(), ItemID.ChlorophyteOre, Main.rand.Next(1, 2));


			}
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(81, 84);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
}