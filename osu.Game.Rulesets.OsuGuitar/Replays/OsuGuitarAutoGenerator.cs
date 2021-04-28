// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Replays;
using osu.Game.Rulesets.OsuGuitar.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.OsuGuitar.Replays
{
    public class OsuGuitarAutoGenerator : AutoGenerator
    {
        protected Replay Replay;
        protected List<ReplayFrame> Frames => Replay.Frames;

        public new Beatmap<OsuGuitarHitObject> Beatmap => (Beatmap<OsuGuitarHitObject>)base.Beatmap;

        public OsuGuitarAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
            Replay = new Replay();
        }

        public override Replay Generate()
        {
            Frames.Add(new OsuGuitarReplayFrame());

            foreach (OsuGuitarHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new OsuGuitarReplayFrame
                {
                    Time = hitObject.StartTime
                    // todo: add required inputs and extra frames.
                });
            }

            return Replay;
        }
    }
}
