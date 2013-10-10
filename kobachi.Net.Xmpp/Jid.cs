using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace kobachi.Net.Xmpp {
	/// <summary>
	/// JIDに関する情報を格納します。
	/// </summary>
	public class Jid: IComparable<Jid> {
		/// <summary>
		/// JIDとして使用するメールアドレスを取得します。
		/// </summary>
		public readonly MailAddress MailAddress { get; private set; }

		/// <summary>
		/// メールアドレスを指定してJIDを初期化します。
		/// </summary>
		/// <param name="address"></param>
		public Jid(string address) {
			MailAddress = new MailAddress(address);
		}

		/// <summary>
		/// このJIDと指定されたインスタンスが等しいかどうかを返します。
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj) {
			if (obj is Jid) {
				return this.MailAddress.Address == ((Jid)obj).MailAddress.Address;
			}
			return false;
		}

		/// <summary>
		/// JidとJidが等しいかどうかを返します。
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool operator ==(Jid a, Jid b) {
			return a != null && b != null && a.Equals(b);
		}

		/// <summary>
		/// JidとJidが等しくないかどうかを返します。
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool operator !=(Jid a, Jid b) {
			return !(a == b);
		}

		/// <summary>
		/// このJidのハッシュ値を取得します。
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode() {
			return this.MailAddress.Address.GetHashCode();
		}

		/// <summary>
		/// このJidと別のJidを比較します。
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(Jid other) {
			if (other == null) {
				return -1;
			}
			return this.MailAddress.Address.CompareTo(other.MailAddress.Address);
		}
	}
}
