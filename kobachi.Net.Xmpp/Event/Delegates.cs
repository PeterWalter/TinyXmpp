using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobachi.Net.Xmpp.Event {
	/// <summary>
	/// 接続を開始した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void ConnectingEventHandler(object sender, EventArgs e);

	/// <summary>
	/// 接続に成功した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void ConnectSuccessEventHandler(object sender, EventArgs e);

	/// <summary>
	/// 接続に失敗した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void ConnectFailEventHandler(object sender, EventArgs e);

	/// <summary>
	/// ストリームの開始を要求した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void StreamStartingEventHandler(object sender, EventArgs e);

	/// <summary>
	/// ストリームが開始した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void StreamStartedEventHandler(object sender, EventArgs e);

	/// <summary>
	/// ストリームの終了を要求した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void StreamEndingEventHandler(object sender, EventArgs e);

	/// <summary>
	/// ストリームが終了した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void StreamEndedEventHandler(object sender, EventArgs e);

	/// <summary>
	/// IQを受信した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void InformationQueryReceivedEventHandler(object sender, EventArgs e);

	/// <summary>
	/// IQの送信を開始した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void InformationQuerySendingEventHandler(object sender, EventArgs e);

	/// <summary>
	/// IQの送信を完了した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void InformationQuerySentEventHandler(object sender, EventArgs e);

	/// <summary>
	/// メッセージを受信した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void MessageReceivedEventHandler(object sender, EventArgs e);

	/// <summary>
	/// メッセージの送信を開始した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void MessageSendingEventHandler(object sender, EventArgs e);

	/// <summary>
	/// メッセージの送信を完了した時のイベントハンドラを格納します。
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void MessageSentEventHandler(object sender, EventArgs e);
}
