﻿using TheGameRoom.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheGameRoom.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class DarkSharkChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("DarkShark58's Chestplate");
			Tooltip.SetDefault("You Found a Dev Set!");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = 10000;
			item.rare = -12;
		}
	}
}