using Terraria.ModLoader;
using Terraria.ID;

namespace TheGameRoom.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class aidenltHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("aidenlt's Head"); 
			Tooltip.SetDefault("You Found a Dev Set!");

		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.rare = -12;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}