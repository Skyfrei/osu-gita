// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.OsuGuitar.Replays
{
    public class OsuGuitarReplayFrame : ReplayFrame
    {
        public List<OsuGuitarAction> Actions = new List<OsuGuitarAction>();

        public OsuGuitarReplayFrame(OsuGuitarAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
