// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class TransferTicketRequest : TeaModel {
        [NameInMap("notify")]
        [Validation(Required=false)]
        public TransferTicketRequestNotify Notify { get; set; }
        public class TransferTicketRequestNotify : TeaModel {
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

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 工单开放ID
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// 工单处理人
        /// </summary>
        [NameInMap("processorUnionId")]
        [Validation(Required=false)]
        public string ProcessorUnionId { get; set; }

        /// <summary>
        /// 被转单人UnionId列表
        /// </summary>
        [NameInMap("processorUnionIds")]
        [Validation(Required=false)]
        public List<string> ProcessorUnionIds { get; set; }

        /// <summary>
        /// 工单备注
        /// </summary>
        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public TransferTicketRequestTicketMemo TicketMemo { get; set; }
        public class TransferTicketRequestTicketMemo : TeaModel {
            /// <summary>
            /// 备注相关的附件
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<TransferTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class TransferTicketRequestTicketMemoAttachments : TeaModel {
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// 文字备注
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

    }

}
