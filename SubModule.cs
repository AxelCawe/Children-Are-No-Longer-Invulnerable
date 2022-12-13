using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace Children_Are_No_Longer_Invulnerable
{
    public class SubModule : MBSubModuleBase
    {
        public static bool PatchesApplied = false;
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);
        }

        public override void OnGameInitializationFinished(Game game)
        {
            if (SubModule.PatchesApplied)
                return;
            new Harmony("ChildrenAreNoLongerInvulnerable").PatchAll();
            SubModule.PatchesApplied = true;
        }
    }
}
