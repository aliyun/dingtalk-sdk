// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ListTicketOperateRecordResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ListTicketOperateRecordResponseBodyRecords> Records { get; set; }
        public class ListTicketOperateRecordResponseBodyRecords : TeaModel {
            /// <summary>
            /// 工单开放ID
            /// </summary>
            [NameInMap("openTicketId")]
            [Validation(Required=false)]
            public string OpenTicketId { get; set; }

            [NameInMap("operateData")]
            [Validation(Required=false)]
            public string OperateData { get; set; }

            /// <summary>
            /// 操作时间
            /// </summary>
            [NameInMap("operateTime")]
            [Validation(Required=false)]
            public string OperateTime { get; set; }

            /// <summary>
            /// 动作
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// 动作展示名
            /// </summary>
            [NameInMap("operationDisplayName")]
            [Validation(Required=false)]
            public string OperationDisplayName { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public ListTicketOperateRecordResponseBodyRecordsOperator Operator { get; set; }
            public class ListTicketOperateRecordResponseBodyRecordsOperator : TeaModel {
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }
            };

            [NameInMap("ticketMemo")]
            [Validation(Required=false)]
            public ListTicketOperateRecordResponseBodyRecordsTicketMemo TicketMemo { get; set; }
            public class ListTicketOperateRecordResponseBodyRecordsTicketMemo : TeaModel {
                [NameInMap("attachments")]
                [Validation(Required=false)]
                public List<ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments> Attachments { get; set; }
                public class ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments : TeaModel {
                    public string FileName { get; set; }
                    public string Key { get; set; }
                }
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }
            };

        }

    }

}
