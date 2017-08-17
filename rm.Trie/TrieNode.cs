using System.Collections.Generic;
using System.Linq;

namespace rm.Trie
{
	/// <summary>
	/// TrieNode node to save WordCount information.
	/// </summary>
	/// <remarks>
	/// TrieNode could inherit from TrieNode{int} and expose a WordCount property
	/// but TrieNode{int}.Value is exposed as public and the design is not
	/// intuitive.
	/// </remarks>
	internal class TrieNode : TrieNodeBase
	{
		#region data members

		/// <summary>
		/// Boolean to indicate whether the root to this node forms a word.
		/// </summary>
		internal bool IsWord
		{
			get { return WordCount > 0; }
		}

		/// <summary>
		/// The count of words for the TrieNode.
		/// </summary>
		internal int WordCount { get; set; }

		#endregion

		#region ctors

		/// <summary>
		/// Creates a new TrieNode instance.
		/// </summary>
		/// <param name="character">The character for the TrieNode.</param>
		internal TrieNode(char character)
			: base(character)
		{
			WordCount = 0;
		}

		#endregion

		#region TrieNodeBase methods

		internal override void Clear()
		{
			base.Clear();
			WordCount = 0;
		}

		internal new TrieNode GetChild(char character)
		{
			return base.GetChild(character) as TrieNode;
		}

		internal new IEnumerable<TrieNode> GetChildren()
		{
			return base.GetChildren().Cast<TrieNode>();
		}

		#endregion
	}
}
