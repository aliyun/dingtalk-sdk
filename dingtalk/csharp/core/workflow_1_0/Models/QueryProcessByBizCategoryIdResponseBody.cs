// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryProcessByBizCategoryIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryProcessByBizCategoryIdResponseBodyResult> Result { get; set; }
        public class QueryProcessByBizCategoryIdResponseBodyResult : TeaModel {
            /// <summary>
            /// 模板描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 模板名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 模板code
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// 模版发布状态。
            /// 
            /// - PUBLISHED：已启用
            /// 
            /// - INVALID：停用
            /// 
            /// - SAVED：已保存
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
