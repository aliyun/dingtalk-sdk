// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class FinishTicketRequest : TeaModel {
        /// <summary>
        /// 工单通知
        /// </summary>
        [NameInMap("notify")]
        [Validation(Required=false)]
        public FinishTicketRequestNotify Notify { get; set; }
        public class FinishTicketRequestNotify : TeaModel {
            /// <summary>
            /// 群中通知接收人（钉钉UnionId）
            /// </summary>
            [NameInMap("groupNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUnionIds { get; set; }

            /// <summary>
            /// 是否向群内推送一个全员可见工单通知卡片
            /// </summary>
            [NameInMap("noticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            /// <summary>
            /// 企业工作通知接收人（钉钉UnionId）
            /// </summary>
            [NameInMap("workNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUnionIds { get; set; }

        }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 工单开放id
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// 当前工单处理人
        /// </summary>
        [NameInMap("processorUnionId")]
        [Validation(Required=false)]
        public string ProcessorUnionId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public FinishTicketRequestTicketMemo TicketMemo { get; set; }
        public class FinishTicketRequestTicketMemo : TeaModel {
            /// <summary>
            /// 备注相关的附件
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<FinishTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class FinishTicketRequestTicketMemoAttachments : TeaModel {
                /// <summary>
                /// 文件名
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// 文件key
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// 备注文字
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

    }

}
