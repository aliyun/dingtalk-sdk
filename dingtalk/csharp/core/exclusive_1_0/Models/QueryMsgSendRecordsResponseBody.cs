// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryMsgSendRecordsResponseBody : TeaModel {
        [NameInMap("errmsg")]
        [Validation(Required=false)]
        public string Errmsg { get; set; }

        [NameInMap("errorcode")]
        [Validation(Required=false)]
        public string Errorcode { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMsgSendRecordsResponseBodyResult Result { get; set; }
        public class QueryMsgSendRecordsResponseBodyResult : TeaModel {
            [NameInMap("item_count")]
            [Validation(Required=false)]
            public int? ItemCount { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<QueryMsgSendRecordsResponseBodyResultItems> Items { get; set; }
            public class QueryMsgSendRecordsResponseBodyResultItems : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1766028831000</para>
                /// </summary>
                [NameInMap("create_time")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("msg_type")]
                [Validation(Required=false)]
                public string MsgType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2569131246</para>
                /// </summary>
                [NameInMap("operator_user_id")]
                [Validation(Required=false)]
                public string OperatorUserId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1766028831000</para>
                /// </summary>
                [NameInMap("send_time")]
                [Validation(Required=false)]
                public long? SendTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pushkxQ2b2DTDAb0qkTjNdKLmwiEiE</para>
                /// </summary>
                [NameInMap("task_id")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文本消息</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
