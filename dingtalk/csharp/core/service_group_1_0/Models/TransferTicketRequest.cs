// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class TransferTicketRequest : TeaModel {
        /// <summary>
        /// 工单处理人
        /// </summary>
        [NameInMap("processorUnionId")]
        [Validation(Required=false)]
        public string ProcessorUnionId { get; set; }

        /// <summary>
        /// 工单开放ID
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

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
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<TransferTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class TransferTicketRequestTicketMemoAttachments : TeaModel {
                public string FileName { get; set; }
                public string Key { get; set; }
            }
        };

        [NameInMap("notify")]
        [Validation(Required=false)]
        public TransferTicketRequestNotify Notify { get; set; }
        public class TransferTicketRequestNotify : TeaModel {
            [NameInMap("workNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUnionIds { get; set; }
            [NameInMap("groupNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUnionIds { get; set; }
            [NameInMap("noticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }
        };

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

    }

}
