using Content.Shared.Interaction;
using Content.Shared.Inventory;
using Content.Shared.MobState;
using Content.Shared.Damage;
using Content.Shared.Verbs;
using Content.Shared.ActionBlocker;
using Content.Shared.Actions;
using Content.Server.Bible.Components;
using Content.Server.MobState;
using Content.Server.Popups;
using Content.Server.Ghost.Roles.Components;
using Content.Server.Ghost.Roles.Events;
using Content.Shared.IdentityManagement;
using Content.Shared.Popups;
using Content.Shared.Timing;
using Robust.Shared.Random;
using Robust.Shared.Audio;
using Robust.Shared.Player;

namespace Content.Server.Tray
{
    public sealed class TraySystem : EntitySystem
    {
        public override void Initialize()
        {
            base.Initialize();

            SubscribeLocalEvent<TrayComponent, AfterInteractEvent>(OnAfterInteract);
        }

        private void OnAfterInteract(EntityUid uid, TrayComponent component, AfterInteractEvent args)
        {
            if (!args.CanReach)
                return;


        }
    }
}
