using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace Minearia.Items
{
    class dontcome : ModItem
    {
        // TODO, count as explosive for demolitionist spawn

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("��Ҷ��׶");
            Tooltip.SetDefault("����Ӱѱ�������һ������� \n ������ͬ��.");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.shootSpeed = 22f;
            item.shoot = mod.ProjectileType("needle");
            item.width = 1;
            item.height = 1;
            item.maxStack = 999;
            item.consumable = true;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 17;
            item.useTime = 17;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.rare = 2;
            item.autoReuse = true;
            item.damage = 20;
            item.knockBack = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlock, 1);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();
        }
    }
}
