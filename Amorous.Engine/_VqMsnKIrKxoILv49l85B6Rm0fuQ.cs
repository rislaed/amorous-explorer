using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Spine;

public static class _VqMsnKIrKxoILv49l85B6Rm0fuQ
{
	public static _nHdiyIURlAiaNZ8u6MKzxjcwnyL _7BVREQXEcBCieHb0qgaVDpUj1ni(this ContentManager contentManager_0, string string_0, float float_0 = 1f, bool bool_0 = true, List<SkeletonJson.SpineEvent> list_0 = null)
	{
		string text = Path.Combine(contentManager_0.RootDirectory, string_0);
		string stream_ = text + ".atlas.txt";
		Stream stream = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My((Stream)(object)stream_);
		Atlas atlas = new Atlas(stream, string_0, _AUtA43NfhBNYDqRrVB1t9VQxe1v._yuFBJdi7mxrwMFQ57BjLjSq6ESj);
		SkeletonJson skeletonJson = new SkeletonJson(atlas)
		{
			Scale = float_0
		};
		string text2 = text + ".json";
		Stream stream2 = _K2047A8SCJdaw0LZKStEHOiH110._E0f25tLwwg9zgWpaN9mFdnGg2My((Stream)(object)text2);
		SkeletonData data = skeletonJson.ReadSkeletonData(stream2, text2, list_0);
		Skeleton skeleton_ = new Skeleton(data);
		stream.Dispose();
		stream2.Dispose();
		return new _nHdiyIURlAiaNZ8u6MKzxjcwnyL(skeleton_, bool_0);
	}
}
