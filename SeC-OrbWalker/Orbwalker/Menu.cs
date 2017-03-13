using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using SharpDX;

namespace SeC_OrbWalker.Orbwalker
{
    class Menu
    {
        public static EloBuddy.SDK.Menu.Menu Config;
        public static EloBuddy.SDK.Menu.Menu Config_Behavier;
        public static EloBuddy.SDK.Menu.Menu Config_Extra;
        public static EloBuddy.SDK.Menu.Menu Config_Drawing;
        internal static void Load()
        {
            Config = MainMenu.AddMenu("SeC-OrbWalker", "orbwalker", "SeC-OrbWalker");
            Config.AddLabel("It uses the Elobuddy Orbwalker Keys but nothing else from it.");
            Config.AddLabel("SeC-Orbwalker will disable Orbwalker as far he can but you still should disable Drawing.");
            Config.AddLabel("Please Rebort Bugs in Elobuddy Forum.");

            Config_Behavier = Config.AddSubMenu("Core", "orbwalker.behavier", "Core");

            Config_Behavier.AddGroupLabel("Priorities - Please If you do not know what it is, do not Modify");
            Config_Behavier.AddLabel("Prioritie Farm </> EnemyHit ( for Harras )");
            Config_Behavier.Add("priorityFarm", new CheckBox("Farm", true));
            Config_Behavier.AddLabel("Prioritie Big </> Small ( for JungleClear )");
            Config_Behavier.Add("priorityJungleBig", new CheckBox("Pref Big Monster", true));

            Config_Behavier.AddGroupLabel("Custom Behavier:");
            Config_Behavier.AddLabel("Attack Objects/Wards");
            Config_Behavier.Add("removeObjects", new CheckBox("Objects", true));
            Config_Behavier.Add("removeWards", new CheckBox("Wards", true));

            Config_Behavier.AddGroupLabel("Special Behaviers:");
            Config_Behavier.AddLabel("POI Means for Melee the Target/ or some Objects (like Catching Axes from Draven)");
            Config_Behavier.AddLabel("Interact Range: if will Change the MovementCommands if POI is inside this Range (from Curser)");
            Config_Behavier.Add("interactRange", new Slider("Interact Range {0}", 350, 0, 800));

            Config_Behavier.AddLabel("Movement Prediction: If Aktive will Semiautomatic your Movement on Melees (for Combo)");
            Config_Behavier.Add("meleePrediction1", new CheckBox("Melee Movement Prediction Auto", false));
            Config_Behavier.Add("meleePrediction2", new CheckBox("Melee Movement Prediction Semi-Auto", false));
            Config_Behavier.AddLabel("Catch Axes Draven: If Aktive Will Catch Axes Inside Interact Range");
            Config_Behavier.Add("CatchAxes", new CheckBox("Draven Catch Axes", true));
            Config_Behavier.Add("CatchAxesW", new CheckBox("Use W for SafeCatch", true));
            Config_Behavier.Add("GPB", new CheckBox("Attack GP Barrels ", true));
            

            Config_Drawing = Config.AddSubMenu("Drawings", "orbwalker.drawings", "Drawing Settings");
            Config_Drawing.AddLabel("Basic Drawing Rules For Your Hero");
            Config_Drawing.Add("drawMyAARange", new CheckBox("Draw AA Range"));
            Config_Drawing.Add("drawMyHoldArea", new CheckBox("Draw Hold Area"));

            Config_Drawing.AddLabel("Basic Drawing Rules For Enemys");
            Config_Drawing.Add("drawEnemyAARange", new CheckBox("Draw AA Range"));
            Config_Drawing.Add("drawEnemyBoundingRadius", new CheckBox("Draw BoundingRadius"));

            Config_Drawing.AddLabel("Interact Range ");
            Config_Drawing.Add("drawInteractCircle", new CheckBox("Draw Interact Circle"));

            Config_Extra = Config.AddSubMenu("Extra", "orbwalker.extra", "Extra Settings");
            Config_Extra.AddLabel("Windup: Its the Time After a Attack before he can Move again.");
            Config_Extra.AddLabel("If you have Increased AA Cancle set this Higher");
            Config_Extra.Add("windup", new Slider("Additional Windup time: {0} ms", 120, 0, 500));
            Config_Extra.AddLabel("i Recomend this : YourPing + 10. EX:ping:40 ,  40 + 10 = 50.  -- WinUPtime = 50");

            Config_Extra.AddLabel("HoldArea: Its a Range Around your Hero.");
            Config_Extra.AddLabel("If your Mouse is inside this Area he wont move to your Cursor ( 0 to Disable)");
            Config_Extra.Add("holdArea", new Slider("HoldArea distance: {0}", 120, 0, 500));
            Config_Extra.AddLabel("Is Recomended to use 120 or + for scape from BAN HAMMER.");

        }
    }
}
