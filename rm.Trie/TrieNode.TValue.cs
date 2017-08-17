using System.Collections.Generic;
using System.Linq;

namespace rm.Trie
{
	/// <summary>
	/// TrieNode[TValue] node to save TValue item.
	/// </summary>
	/// <typeparam name="TValue">Type of Value at each TrieNode.</typeparam>
	internal class TrieNode<TValue> : TrieNodeBase
	{
		#region data members

		/// <summary>
		/// TValue item.
		/// </summary>
		public TValue Value
		{
			get { return _value; }
			internal set
			{
				if (value == null)
				{
					hasValue = false;
					_value = value;
					return;
				}
				_value = value;
				hasValue = true;
			}
		}
		private bool hasValue;
		private TValue _value;

		#endregion

		#region ctors

		/// <summary>
		/// Creates a new TrieNode instance.
		/// </summary>
		internal TrieNode(char character)
			: base(character)
		{ }

		#endregion

		/// <summary>
		/// Returns true if contains value.
		/// </summary>
		internal bool HasValue()
		{
			return hasValue;
		}

		#region TrieNodeBase

		internal override void Clear()
		{
			base.Clear();
			Value = default(TValue);
			hasValue = false;
		}

		internal new TrieNode<TValue> GetChild(char character)
		{
			return base.GetChild(character) as TrieNode<TValue>;
		}

		internal new IEnumerable<TrieNode<TValue>> GetChildren()
		{
			return base.GetChildren().Cast<TrieNode<TValue>>();
		}

		#endregion
	}
}
