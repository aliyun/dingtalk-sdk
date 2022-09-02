// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchSendOfficialAccountOTOMessageRequest : TeaModel {
        /// <summary>
        /// 服务窗帐号ID
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 服务窗授权的调用方标识，可空
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// 消息详情
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public BatchSendOfficialAccountOTOMessageRequestDetail Detail { get; set; }
        public class BatchSendOfficialAccountOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// 业务请求标识，当一次业务请求需要多次调用发送API时可以设置此参数，方便后续跟踪处理。
            /// </summary>
            [NameInMap("bizRequestId")]
            [Validation(Required=false)]
            public string BizRequestId { get; set; }

            /// <summary>
            /// 消息体
            /// </summary>
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody MessageBody { get; set; }
            public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBody : TeaModel {
                /// <summary>
                /// 卡片消息
                /// </summary>
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard : TeaModel {
                    /// <summary>
                    /// 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
                    /// </summary>
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
                        /// <summary>
                        /// 使用独立跳转ActionCard样式时的跳转链接。
                        /// </summary>
                        [NameInMap("actionUrl")]
                        [Validation(Required=false)]
                        public string ActionUrl { get; set; }

                        /// <summary>
                        /// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
                    /// </summary>
                    [NameInMap("buttonOrientation")]
                    [Validation(Required=false)]
                    public string ButtonOrientation { get; set; }

                    /// <summary>
                    /// 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
                    /// </summary>
                    [NameInMap("markdown")]
                    [Validation(Required=false)]
                    public string Markdown { get; set; }

                    /// <summary>
                    /// 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
                    /// </summary>
                    [NameInMap("singleTitle")]
                    [Validation(Required=false)]
                    public string SingleTitle { get; set; }

                    /// <summary>
                    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
                    /// </summary>
                    [NameInMap("singleUrl")]
                    [Validation(Required=false)]
                    public string SingleUrl { get; set; }

                    /// <summary>
                    /// 透出到会话列表和通知的文案
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// 链接消息类型
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink Link { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink : TeaModel {
                    /// <summary>
                    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
                    /// </summary>
                    [NameInMap("messageUrl")]
                    [Validation(Required=false)]
                    public string MessageUrl { get; set; }

                    /// <summary>
                    /// 图片地址
                    /// </summary>
                    [NameInMap("picUrl")]
                    [Validation(Required=false)]
                    public string PicUrl { get; set; }

                    /// <summary>
                    /// 消息描述，建议500字符以内。
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// 消息标题，建议100字符以内。
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// markdown消息，仅对消息类型为markdown时有效
                /// </summary>
                [NameInMap("markdown")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
                    /// <summary>
                    /// markdown格式的消息，建议500字符以内。
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// 首屏会话透出的展示内容。
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// 文本消息体  对于文本类型消息时必填
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText : TeaModel {
                    /// <summary>
                    /// 消息内容，建议500字符以内。
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

            }

            /// <summary>
            /// 消息类型
            /// </summary>
            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }

            /// <summary>
            /// 全员群发
            /// </summary>
            [NameInMap("sendToAll")]
            [Validation(Required=false)]
            public bool? SendToAll { get; set; }

            /// <summary>
            /// 消息接收人列表，最多支持1000人
            /// </summary>
            [NameInMap("userIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

            /// <summary>
            /// 消息请求唯一ID
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
