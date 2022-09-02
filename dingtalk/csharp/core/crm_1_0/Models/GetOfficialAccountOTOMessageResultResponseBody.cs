// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountOTOMessageResultResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetOfficialAccountOTOMessageResultResponseBodyResult Result { get; set; }
        public class GetOfficialAccountOTOMessageResultResponseBodyResult : TeaModel {
            /// <summary>
            /// 已读消息的userid列表
            /// </summary>
            [NameInMap("readUserIdList")]
            [Validation(Required=false)]
            public List<string> ReadUserIdList { get; set; }

            /// <summary>
            /// 执行状态： 0：未开始  1：处理中  2：处理完毕
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

    }

}
