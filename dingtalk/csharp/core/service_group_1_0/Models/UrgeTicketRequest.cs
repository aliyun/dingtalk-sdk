// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class UrgeTicketRequest : TeaModel {
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

        /// <summary>
        /// 工单催单操作人UnionId
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

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
        public UrgeTicketRequestTicketMemo TicketMemo { get; set; }
        public class UrgeTicketRequestTicketMemo : TeaModel {
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<UrgeTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class UrgeTicketRequestTicketMemoAttachments : TeaModel {
                public string FileName { get; set; }
                public string Key { get; set; }
            }
        };

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
