using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minearia.Items
{
    public class Glouw : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("����ʽӫ���");
            Tooltip.SetDefault("���۰����� \n��˵����Ҫ�й⣡");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.shootSpeed = 10f;
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.shoot = mod.ProjectileType("Glouwt");
            item.value = 100;
            item.consumable = true;
            item.UseSound = SoundID.Item1;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.rare = 1;
            item.holdStyle = 1;
            item.flame = true;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glowstick, 5);
            recipe.AddIngredient(ItemID.Gel, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}