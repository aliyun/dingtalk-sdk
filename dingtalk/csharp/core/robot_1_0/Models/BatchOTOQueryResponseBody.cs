// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchOTOQueryResponseBody : TeaModel {
        /// <summary>
        /// 消息已读情况
        /// </summary>
        [NameInMap("messageReadInfoList")]
        [Validation(Required=false)]
        public List<BatchOTOQueryResponseBodyMessageReadInfoList> MessageReadInfoList { get; set; }
        public class BatchOTOQueryResponseBodyMessageReadInfoList : TeaModel {
            /// <summary>
            /// 姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 已读状态
            /// </summary>
            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public string ReadStatus { get; set; }

            /// <summary>
            /// 已读时间
            /// </summary>
            [NameInMap("readTimestamp")]
            [Validation(Required=false)]
            public long? ReadTimestamp { get; set; }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 消息发送状态
        /// </summary>
        [NameInMap("sendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

    }

}
