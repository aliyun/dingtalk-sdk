// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchSendOfficialAccountOTOMessageRequest : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public BatchSendOfficialAccountOTOMessageRequestDetail Detail { get; set; }
        public class BatchSendOfficialAccountOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("bizRequestId")]
            [Validation(Required=false)]
            public string BizRequestId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messageBody")]
            [Validation(Required=false)]
            public BatchSendOfficialAccountOTOMessageRequestDetailMessageBody MessageBody { get; set; }
            public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBody : TeaModel {
                [NameInMap("actionCard")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard ActionCard { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard : TeaModel {
                    [NameInMap("buttonList")]
                    [Validation(Required=false)]
                    public List<BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList> ButtonList { get; set; }
                    public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("actionUrl")]
                        [Validation(Required=false)]
                        public string ActionUrl { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    [NameInMap("buttonOrientation")]
                    [Validation(Required=false)]
                    public string ButtonOrientation { get; set; }

                    [NameInMap("markdown")]
                    [Validation(Required=false)]
                    public string Markdown { get; set; }

                    [NameInMap("singleTitle")]
                    [Validation(Required=false)]
                    public string SingleTitle { get; set; }

                    [NameInMap("singleUrl")]
                    [Validation(Required=false)]
                    public string SingleUrl { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("link")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink Link { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("messageUrl")]
                    [Validation(Required=false)]
                    public string MessageUrl { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("picUrl")]
                    [Validation(Required=false)]
                    public string PicUrl { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown Markdown { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText Text { get; set; }
                public class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }

            [NameInMap("sendToAll")]
            [Validation(Required=false)]
            public bool? SendToAll { get; set; }

            [NameInMap("userIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
