using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobachi.Net.Xmpp {
	/// <summary>
	/// ユーザーに関する情報を格納します。
	/// </summary>
	public class UserInfo {
		/// <summary>
		/// ユーザーのJIDを取得します。
		/// </summary>
		public Jid Jid { get; private set; }

		/// <summary>
		/// ユーザーが所属するグループを取得または設定します。
		/// </summary>
		public string Group { get; set; }

		/// <summary>
		/// このUserInfoと指定されたインスタンスが等しいかどうかを返します。
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj) {
			return obj is UserInfo ? this.Jid == ((UserInfo)obj).Jid : false;
		}

		/// <summary>
		/// UserInfoとUserInfoが等しいかどうかを返します。
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator ==(UserInfo a, UserInfo b){
			return a != null && b != null && a.Equals(b);
		}

		/// <summary>
		/// UserInfoとUserInfoが等しくないかどうかを返します。
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator !=(UserInfo a, UserInfo b) {
			return !(a == b);
		}

		/// <summary>
		/// このUserInfoのハッシュ値を取得します。
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode() {
			return this.Jid.GetHashCode();
		}
	}
}
