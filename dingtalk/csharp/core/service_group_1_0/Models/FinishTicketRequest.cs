// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class FinishTicketRequest : TeaModel {
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

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 当前工单处理人
        /// </summary>
        [NameInMap("processorUnionId")]
        [Validation(Required=false)]
        public string ProcessorUnionId { get; set; }

        /// <summary>
        /// 工单开放id
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public FinishTicketRequestTicketMemo TicketMemo { get; set; }
        public class FinishTicketRequestTicketMemo : TeaModel {
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<FinishTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class FinishTicketRequestTicketMemoAttachments : TeaModel {
                public string FileName { get; set; }
                public string Key { get; set; }
            }
        };

        /// <summary>
        /// 工单通知
        /// </summary>
        [NameInMap("notify")]
        [Validation(Required=false)]
        public FinishTicketRequestNotify Notify { get; set; }
        public class FinishTicketRequestNotify : TeaModel {
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

    }

}
