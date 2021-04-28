// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.OsuGuitar.Objects;
using osu.Game.Rulesets.OsuGuitar.Objects.Drawables;
using osu.Game.Rulesets.OsuGuitar.Replays;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.UI.Scrolling;

namespace osu.Game.Rulesets.OsuGuitar.UI
{
    [Cached]
    public class DrawableOsuGuitarRuleset : DrawableScrollingRuleset<OsuGuitarHitObject>
    {
        public DrawableOsuGuitarRuleset(OsuGuitarRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
            Direction.Value = ScrollingDirection.Left;
            TimeRange.Value = 6000;
        }

        protected override Playfield CreatePlayfield() => new OsuGuitarPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new OsuGuitarFramedReplayInputHandler(replay);

        public override DrawableHitObject<OsuGuitarHitObject> CreateDrawableRepresentation(OsuGuitarHitObject h) => new DrawableOsuGuitarHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new OsuGuitarInputManager(Ruleset?.RulesetInfo);
    }
}
