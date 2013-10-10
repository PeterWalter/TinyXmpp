using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobachi.Net.Xmpp {
	/// <summary>
	/// UserInfoの一覧を格納します。
	/// </summary>
	public class UserInfoCollection: ICollection<UserInfo> {
		/// <summary>
		/// ユーザーの一覧
		/// </summary>
		private LinkedList<UserInfo> users;

		/// <summary>
		/// UserInfoCollectionのバージョン文字列を取得または設定します。
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// JIDを指定してUserInfoを取得します。
		/// </summary>
		/// <param name="jid"></param>
		/// <returns></returns>
		public UserInfo this[Jid jid]{
			get{
				foreach(UserInfo u in users){
					if (u.Jid != jid) {
						continue;
					}
					return u;
				}
				return null;
			}
			private set{
				foreach (UserInfo u in users) {
					if (u.Jid != jid) {
						continue;
					}
					if (u.Jid != value.Jid) {
						throw new InvalidOperationException("JIDが異なるユーザーを代入することはできません。");
					}
					users.AddBefore(users.Find(u), value);
					users.Remove(u);
					break;
				}
			}
		}

		public UserInfoCollection() {
			users = new LinkedList<UserInfo>();
		}

		/// <summary>
		/// UserInfoCollectionに新しいユーザーを追加します。
		/// </summary>
		/// <param name="item"></param>
		public void Add(UserInfo item) {
			if (users.Contains(item)) {
				throw new ArgumentException("指定されたユーザーは既に追加されています");
			}
			users.AddLast(item);
		}

		/// <summary>
		/// UserInfoCollectionをクリアします。
		/// </summary>
		public void Clear() {
			users.Clear();
		}

		/// <summary>
		/// UserInfoCollectionに指定されたUserInfoが含まれているかどうかを返します。
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public bool Contains(UserInfo item) {
			return users.Contains(item);
		}

		/// <summary>
		/// UserInfoCollectionの要素を、指定された配列にコピーします。
		/// </summary>
		/// <param name="array"></param>
		/// <param name="arrayIndex"></param>
		public void CopyTo(UserInfo[] array, int arrayIndex) {
			users.CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// UserInfoCollectionの要素数を取得します。
		/// </summary>
		public int Count {
			get {
				return users.Count;
			}
		}

		/// <summary>
		/// UserInfoCollectionが読み取り専用かどうかを返します。
		/// </summary>
		public bool IsReadOnly {
			get {
				return false;
			}
		}

		/// <summary>
		/// UserInfoCollectionから、指定されたUserInfoを削除します。
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public bool Remove(UserInfo item) {
			return users.Remove(item);
		}

		/// <summary>
		/// UserInfoCollectionを列挙します。
		/// </summary>
		/// <returns></returns>
		public IEnumerator<UserInfo> GetEnumerator() {
			return users.GetEnumerator();
		}

		/// <summary>
		/// UserInfoCollectionを列挙します。
		/// </summary>
		/// <returns></returns>
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return users.GetEnumerator();
		}
	}
}
