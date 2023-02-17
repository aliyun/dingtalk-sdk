// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class ListObjectiveByUserResponseBody : TeaModel {
        /// <summary>
        /// 请求返回数据对象
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public ListObjectiveByUserResponseBodyContent Content { get; set; }
        public class ListObjectiveByUserResponseBodyContent : TeaModel {
            /// <summary>
            /// 总数
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("objectives")]
            [Validation(Required=false)]
            public List<OpenObjectiveDTO> Objectives { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 接口请求是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
