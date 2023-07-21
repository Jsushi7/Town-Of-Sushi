using System;
using UnityEngine;
using TMPro;
using AmongUs.GameOptions;
using TownOfRoles.Extensions;

namespace TownOfRoles.Roles
{
    public class Guardian : Role
    {
        public bool Enabled;
        public DateTime LastProtected;
        public float TimeRemaining;
        public bool GAImpWin { get; set; }
        public int UsesLeft;
        public TextMeshPro UsesText;

        public bool ButtonUsable => UsesLeft != 0;

        public PlayerControl target;

        public Guardian(PlayerControl player) : base(player)
        {
            Name = "Guardian";
            StartText = () =>
                target == null ? "<color=#B3FFFFFF>You don't have a client for some reason... weird...</color>" : $"<color=#B3FFFFFF>Protect {target.name} With Your Life!</color>";
            TaskText = () =>
                target == null
                    ? "You don't have a client for some reason... weird..."
                    : $"Protect your client!\nClient: {target.name}";
            Color = Patches.Colors.Guardian;
            LastProtected = DateTime.UtcNow;
            FactionName = "<color=#5c5e5d>Neutral</color>";                
            RoleType = RoleEnum.Guardian;
            AddToRoleHistory(RoleType);
            Faction = Faction.Neutral;
            Scale = 1.4f;

            UsesLeft = CustomGameOptions.MaxProtects;
        }

        public bool Protecting => TimeRemaining > 0f;

        public float ProtectTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastProtected;
            var num = CustomGameOptions.ProtectCd * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }

        public void Protect()
        {
            Enabled = true;
            TimeRemaining -= Time.deltaTime;
        }


        public void UnProtect()
        {
            var ga = GetRole<Guardian>(Player);
            if (!ga.target.IsShielded())
            {
                ga.target.myRend().material.SetColor("_VisorColor", Palette.VisorColor);
                ga.target.myRend().material.SetFloat("_Outline", 0f);
            }
            Enabled = false;
            LastProtected = DateTime.UtcNow;
        }

        public void ImpTargetWin()
        {
            Player.Data.Role.TeamType = RoleTeamTypes.Impostor;
            if (Player.Data.IsDead) RoleManager.Instance.SetRole(Player, RoleTypes.ImpostorGhost);
            else RoleManager.Instance.SetRole(Player, RoleTypes.Impostor);
        }

        public void ImpTargetLose()
        {
            LostByRPC = true;
        }

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__36 __instance)
        {
            var gaTeam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            gaTeam.Add(PlayerControl.LocalPlayer);
            gaTeam.Add(target);
            __instance.teamToShow = gaTeam;
        }
    }
}