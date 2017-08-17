using System.Collections.Generic;

namespace rm.Trie
{
	/// <summary>
	/// Interface for TrieMap data structure.
	/// </summary>
	/// <typeparam name="TValue">Type of Value at each TrieNode.</typeparam>
	public interface ITrieMap<TValue>
	{
		/// <summary>
		/// Gets TValue item for key from TrieMap.
		/// </summary>
		TValue ValueBy(string key);

		/// <summary>
		/// Gets TValue items by key prefix from TrieMap.
		/// </summary>
		IEnumerable<TValue> ValuesBy(string keyPrefix);

		/// <summary>
		/// Gets all TValue items from TrieMap.
		/// </summary>
		IEnumerable<TValue> Values();

		/// <summary>
		/// Gets all keys from TrieMap.
		/// </summary>
		IEnumerable<string> Keys();

		/// <summary>
		/// Gets all string->TValue pairs from TrieMap.
		/// </summary>
		IEnumerable<KeyValuePair<string, TValue>> KeyValuePairs();

		/// <summary>
		/// Adds TValue item for key to TrieMap.
		/// </summary>
		void Add(string key, TValue value);

		/// <summary>
		/// Returns true if key present in TrieMap.
		/// </summary>
		bool HasKey(string key);

		/// <summary>
		/// Returns true if key prefix present in TrieMap.
		/// </summary>
		bool HasKeyPrefix(string keyPrefix);

		/// <summary>
		/// Removes key from TrieMap.
		/// </summary>
		void Remove(string key);

		/// <summary>
		/// Removes key prefix from TrieMap and return true else false.
		/// </summary>
		bool RemoveKeyPrefix(string keyPrefix);

		/// <summary>
		/// Clears all values from TrieMap.
		/// </summary>
		void Clear();
	}
}
