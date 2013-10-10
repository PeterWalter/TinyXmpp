using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobachi.Net.Xmpp {
	public class XmppClient {
		/// <summary>
		/// 接続中かどうかを取得します。
		/// </summary>
		public bool Connected { get; private set; }

		/// <summary>
		/// SSL接続を使用しているかどうかを取得します。
		/// </summary>
		public bool UsingSSL { get; private set; }

		private Jid jid;

		/// <summary>
		/// 接続に使用するJIDを取得または設定します。
		/// </summary>
		public Jid Jid {
			get {
				return jid;
			}
			set {
				if (Connected) {
					throw new InvalidOperationException();
				}
				jid = value;
			}
		}

		private string resource;

		/// <summary>
		/// リソース文字列を取得または設定します。
		/// </summary>
		public string Resource {
			get {
				return resource;
			}
			set {
				if (Connected) {
					throw new InvalidOperationException();
				}
				resource = value;
			}
		}

		/// <summary>
		/// セッションIDを取得します。
		/// </summary>
		protected string SessionId { get; private set; }

		private UserInfoCollection users;

		/// <summary>
		/// ユーザーの一覧を取得します。
		/// </summary>
		public UserInfoCollection Users {
			get {
				if (users == null) {
					RefreshUsers();
				}
				return users;
			}
		}

		/// <summary>
		/// ユーザーの一覧を更新します。
		/// </summary>
		public async void RefreshUsers() {
			//users = 
			throw new NotImplementedException();
		}

		/// <summary>
		/// イニシャルプレゼンスを送信します。
		/// </summary>
		protected void SendInitialPresence() {
			throw new NotImplementedException();
		}

		/// <summary>
		/// 無効プレゼンスを送信します。
		/// </summary>
		protected void SendUnavilablePresence() {
			throw new NotImplementedException();
		}

		/// <summary>
		/// pingを送信します。
		/// </summary>
		protected void SendPing() {
			throw new NotImplementedException();
		}
	}
}
