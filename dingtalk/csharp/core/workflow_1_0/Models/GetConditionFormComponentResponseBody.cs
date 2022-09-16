// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetConditionFormComponentResponseBody : TeaModel {
        /// <summary>
        /// 返回结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetConditionFormComponentResponseBodyResult> Result { get; set; }
        public class GetConditionFormComponentResponseBodyResult : TeaModel {
            /// <summary>
            /// 表单ID。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 表单名称。
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

    }

}
