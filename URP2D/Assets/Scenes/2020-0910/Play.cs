using UnityEngine;
using UnityEngine.Playables;

public class Play : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        PlayableGraph graph;
        var clip = MakeClip();
        var playable = AnimationPlayableUtilities.PlayClip(animator, clip, out graph);
    }

    AnimationClip MakeClip()
    {
        var clip = new AnimationClip();
        clip.frameRate = 7;
        return clip;
    }
}
