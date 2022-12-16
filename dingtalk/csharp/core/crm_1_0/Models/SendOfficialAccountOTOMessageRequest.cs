// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class SendOfficialAccountOTOMessageRequest : TeaModel {
        /// <summary>
        /// 服务窗帐号ID
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// API调用标识，可选参数
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// 消息详情
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendOfficialAccountOTOMessageRequestDetail Detail { get; set; }
        public class SendOfficialAccountOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// 消息体
            /// </summary>
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public SendOfficialAccountOTOMessageRequestDetailMessageBody MessageBody { get; set; }
            public class SendOfficialAccountOTOMessageRequestDetailMessageBody : TeaModel {
                /// <summary>
                /// 卡片消息
                /// </summary>
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard : TeaModel {
                    /// <summary>
                    /// 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
                    /// </summary>
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
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
                /// 图片消息类型时，此参数必填。 设置此参数时，msgType必须为image类型
                /// </summary>
                [NameInMap("image")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyImage Image { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyImage : TeaModel {
                    /// <summary>
                    /// 图片mediaId，可以通过上传媒体文件接口上传图片获取mediaId。
                    /// </summary>
                    [NameInMap("mediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                }

                /// <summary>
                /// 链接消息类型
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyLink Link { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink : TeaModel {
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
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
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
                public SendOfficialAccountOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class SendOfficialAccountOTOMessageRequestDetailMessageBodyText : TeaModel {
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
            /// 消息接收人unionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 消息接收人id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 请求唯一 ID
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
