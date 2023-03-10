using System;
using System.ComponentModel;
using System.Linq;

namespace SysBot.Pokemon
{
    public class QQSettings
    {
        private const string Startup = nameof(Startup);
        private const string Operation = nameof(Operation);
        private const string Messages = nameof(Messages);
        public override string ToString() => "QQ整合设置";

        // Startup

        [Category(Startup), Description("Mirai Bot地址，默认端口为8080，请与Mirai中的端口保持一致")]
        public string Address { get; set; } = "localhost:8080";

        [Category(Startup), Description("Mirai Bot验证密钥，默认密钥为1234567890 请与Mirai中的密钥保持一致")]
        public string VerifyKey { get; set; } = "1234567890";

        [Category(Startup), Description("你的机器人的QQ号")]
        public string QQ { get; set; } = string.Empty;

        [Category(Startup), Description("发送消息的QQ群号")]
        public string GroupId { get; set; } = string.Empty;

        [Category(Startup), Description("发送交换密码的模式：1为群发；2为私发；3仅为好友私发,非好友取消交易；4为好友私发,非好友群发；其他数字为群发")]
        public int TradeCodeMethod { get; set; } = 1;

        [Category(Startup), Description("发送交换得到精灵信息(精灵名字、训练家、表id、里id)的方式：1为全不发送；2为群聊发送；3为私聊发送；4为好友私发，非好友不发送；5为好友私发,非好友群发；其他数字为不发送")]
        public int TidAndSidMethod { get; set; } = 2;

        [Category(Startup), Description("是否保存文字批量生成的文件，true为保存，false为不保存")]
        public bool BatchFile { get; set; } = true;

        [Category(Startup), Description("是否保存bin批量生成的文件，true为保存，false为不保存")]
        public bool BatchBinFile { get; set; } = true;

        [Category(Startup), Description("文字批量宝可梦数量限制，最小为2")]
        public int qqBatchTradeMaxNumber { get; set; } = 3;

        [Category(Startup), Description("bin批量文件中宝可梦数量限制，最小为1，最大为960")]
        public int qqBinTradeMaxNumber { get; set; } = 3;

        [Category(Startup), Description("qq文字批量交换开关，true开启，false为关闭")]
        public bool BatchTradeSwitch { get; set; } = true;

        [Category(Startup), Description("bin文件批量交换开关，true开启，false为关闭")]
        public bool BinTradeSwitch { get; set; } = true;

        [Category(Startup), Description("ps队伍代码交换开关，true开启，false为关闭")]
        public bool PSTeamTradeSwitch { get; set; } = true;

        [Category(Startup), Description("机器人回复的触发词1")]
        public string AliveMsgOne { get; set; } = "关键词1"; 

        [Category(Startup), Description("机器人回复消息1")]
        public string ReplyMsgOne { get; set; } = "回复1";

        [Category(Startup), Description("机器人回复的触发词2")]
        public string AliveMsgTwo { get; set; } = "关键词2";

        [Category(Startup), Description("机器人回复消息2")]
        public string ReplyMsgTwo { get; set; } = "回复2";

        [Category(Startup), Description("机器人回复的触发词3")]
        public string AliveMsgThree { get; set; } = "关键词3";

        [Category(Startup), Description("机器人回复消息3")]
        public string ReplyMsgThree { get; set; } = "回复3";

        [Category(Operation), Description("屏障释放时发送的消息")]
        public string MessageStart { get; set; } = string.Empty;
    }
}