// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkevent_1_0.Models
{
    public class GetCallBackFaileResultResponseBody : TeaModel {
        /// <summary>
        /// 推送失败的事件列表，一次最多200个。
        /// </summary>
        [NameInMap("failedList")]
        [Validation(Required=false)]
        public List<GetCallBackFaileResultResponseBodyFailedList> FailedList { get; set; }
        public class GetCallBackFaileResultResponseBodyFailedList : TeaModel {
            /// <summary>
            /// 返回的事件内容
            /// </summary>
            [NameInMap("callBackData")]
            [Validation(Required=false)]
            public string CallBackData { get; set; }

            /// <summary>
            /// 事件类型
            /// </summary>
            [NameInMap("callBackTag")]
            [Validation(Required=false)]
            public string CallBackTag { get; set; }

            /// <summary>
            /// 事件所属的corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 事件的时间戳。
            /// </summary>
            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

        }

        /// <summary>
        /// 是否还有推送失败的变更事件，若为true，则表示还有未回调的事件，或传入时间时范围内还有未回调的事件。
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

    }

}
