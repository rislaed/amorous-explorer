using System;
using Spine;

public class _NxPDyghimJKCwBg53DaNTazjQ5k
{
	private readonly ExposedList<Polygon> _sc6AWQNc7BlGAmNMydEy7sD8v1j;

	private readonly ExposedList<Polygon> _A9kKAOOHImeN1Bymg7Y86T6pyXf;

	public float _SjhHztt8d5kOtb7Z2BJKnZZxEKh { get; private set; }

	public float _xqxFKfudZYzf8RtrC7EB1Ya6FPT { get; private set; }

	public float _nVnyJkkce6HsdRrKSpRrzUDElg0 { get; private set; }

	public float _pFgHmGjnwllBZ83LhpZv0o8ZcO { get; private set; }

	public float _je8rVfyg4zywmqSi4Ozx1z7wJ4b => _nVnyJkkce6HsdRrKSpRrzUDElg0 - _SjhHztt8d5kOtb7Z2BJKnZZxEKh;

	public float _WJfGWBzn4wgdGBnMWRH2pcJ3AqH => _pFgHmGjnwllBZ83LhpZv0o8ZcO - _xqxFKfudZYzf8RtrC7EB1Ya6FPT;

	public _NxPDyghimJKCwBg53DaNTazjQ5k()
	{
		_sc6AWQNc7BlGAmNMydEy7sD8v1j = new ExposedList<Polygon>();
		_A9kKAOOHImeN1Bymg7Y86T6pyXf = new ExposedList<Polygon>();
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(Skeleton skeleton_0)
	{
		_sc6AWQNc7BlGAmNMydEy7sD8v1j.AddRange(_A9kKAOOHImeN1Bymg7Y86T6pyXf);
		_A9kKAOOHImeN1Bymg7Y86T6pyXf.Clear();
		ExposedList<Slot> slots = skeleton_0.Slots;
		int count = slots.Count;
		for (int i = 0; i < count; i++)
		{
			Slot slot = slots.Items[i];
			if (slot.A <= 0f)
			{
				continue;
			}
			if (!(slot.Attachment is RegionAttachment))
			{
				if (slot.Attachment is MeshAttachment)
				{
					MeshAttachment meshAttachment = slot.Attachment as MeshAttachment;
					Polygon polygon = _JFnByzmaHsFolNK380WoVrfnqoo();
					_A9kKAOOHImeN1Bymg7Y86T6pyXf.Add(polygon);
					polygon.Vertices = new float[meshAttachment.Vertices.Length];
					meshAttachment.ComputeWorldVertices(slot, polygon.Vertices);
				}
				else if (slot.Attachment is SkinnedMeshAttachment)
				{
					SkinnedMeshAttachment skinnedMeshAttachment = slot.Attachment as SkinnedMeshAttachment;
					Polygon polygon2 = _JFnByzmaHsFolNK380WoVrfnqoo();
					_A9kKAOOHImeN1Bymg7Y86T6pyXf.Add(polygon2);
					polygon2.Vertices = new float[skinnedMeshAttachment.UVs.Length];
					skinnedMeshAttachment.ComputeWorldVertices(slot, polygon2.Vertices);
				}
			}
			else
			{
				RegionAttachment regionAttachment = slot.Attachment as RegionAttachment;
				Polygon polygon3 = _JFnByzmaHsFolNK380WoVrfnqoo();
				_A9kKAOOHImeN1Bymg7Y86T6pyXf.Add(polygon3);
				polygon3.Vertices = new float[8];
				regionAttachment.ComputeWorldVertices(slot.Bone, polygon3.Vertices);
			}
		}
		if (_A9kKAOOHImeN1Bymg7Y86T6pyXf.Count == 0)
		{
			_SjhHztt8d5kOtb7Z2BJKnZZxEKh = 0f;
			_xqxFKfudZYzf8RtrC7EB1Ya6FPT = 0f;
			_nVnyJkkce6HsdRrKSpRrzUDElg0 = 0f;
			_pFgHmGjnwllBZ83LhpZv0o8ZcO = 0f;
		}
		else
		{
			_zVkDLJ3sBUdJJ1CIpOaDUdk4l4fB();
		}
	}

	private Polygon _JFnByzmaHsFolNK380WoVrfnqoo()
	{
		int count = _sc6AWQNc7BlGAmNMydEy7sD8v1j.Count;
		Polygon result;
		if (count > 0)
		{
			result = _sc6AWQNc7BlGAmNMydEy7sD8v1j.Items[count - 1];
			_sc6AWQNc7BlGAmNMydEy7sD8v1j.RemoveAt(count - 1);
		}
		else
		{
			result = new Polygon();
		}
		return result;
	}

	private void _zVkDLJ3sBUdJJ1CIpOaDUdk4l4fB()
	{
		float num = 2.1474836E+09f;
		float num2 = 2.1474836E+09f;
		float num3 = -2.1474836E+09f;
		float num4 = -2.1474836E+09f;
		int i = 0;
		for (int count = _A9kKAOOHImeN1Bymg7Y86T6pyXf.Count; i < count; i++)
		{
			Polygon polygon = _A9kKAOOHImeN1Bymg7Y86T6pyXf.Items[i];
			float[] vertices = polygon.Vertices;
			int j = 0;
			for (int num5 = vertices.Length; j < num5; j += 2)
			{
				float val = vertices[j];
				float val2 = vertices[j + 1];
				num = Math.Min(num, val);
				num2 = Math.Min(num2, val2);
				num3 = Math.Max(num3, val);
				num4 = Math.Max(num4, val2);
			}
		}
		_SjhHztt8d5kOtb7Z2BJKnZZxEKh = num;
		_xqxFKfudZYzf8RtrC7EB1Ya6FPT = num2;
		_nVnyJkkce6HsdRrKSpRrzUDElg0 = num3;
		_pFgHmGjnwllBZ83LhpZv0o8ZcO = num4;
	}

	static ExposedList<Slot> smethod_0(Skeleton skeleton_0)
	{
		return skeleton_0.Slots;
	}

	static float smethod_1(Slot slot_0)
	{
		return slot_0.A;
	}

	static Attachment smethod_2(Slot slot_0)
	{
		return slot_0.Attachment;
	}

	static void smethod_3(Polygon polygon_0, float[] float_0)
	{
		polygon_0.Vertices = float_0;
	}

	static Bone smethod_4(Slot slot_0)
	{
		return slot_0.Bone;
	}

	static float[] smethod_5(Polygon polygon_0)
	{
		return polygon_0.Vertices;
	}

	static void smethod_6(RegionAttachment regionAttachment_0, Bone bone_0, float[] float_0)
	{
		regionAttachment_0.ComputeWorldVertices(bone_0, float_0);
	}

	static float[] smethod_7(MeshAttachment meshAttachment_0)
	{
		return meshAttachment_0.Vertices;
	}

	static void smethod_8(MeshAttachment meshAttachment_0, Slot slot_0, float[] float_0)
	{
		meshAttachment_0.ComputeWorldVertices(slot_0, float_0);
	}

	static float[] smethod_9(SkinnedMeshAttachment skinnedMeshAttachment_0)
	{
		return skinnedMeshAttachment_0.UVs;
	}

	static void smethod_10(SkinnedMeshAttachment skinnedMeshAttachment_0, Slot slot_0, float[] float_0)
	{
		skinnedMeshAttachment_0.ComputeWorldVertices(slot_0, float_0);
	}

	static Polygon smethod_11()
	{
		return new Polygon();
	}

	static float smethod_12(float float_0, float float_1)
	{
		return Math.Min(float_0, float_1);
	}

	static float smethod_13(float float_0, float float_1)
	{
		return Math.Max(float_0, float_1);
	}
}
