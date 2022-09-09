// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListUserVisibleBpmsProcessesResponseBody : TeaModel {
        /// <summary>
        /// 返回结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListUserVisibleBpmsProcessesResponseBodyResult Result { get; set; }
        public class ListUserVisibleBpmsProcessesResponseBodyResult : TeaModel {
            /// <summary>
            /// 下一次分页调用的值，当返回结果里没有nextToken时，表示分页结束。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

            /// <summary>
            /// 可见表单列表。
            /// </summary>
            [NameInMap("processList")]
            [Validation(Required=false)]
            public List<ListUserVisibleBpmsProcessesResponseBodyResultProcessList> ProcessList { get; set; }
            public class ListUserVisibleBpmsProcessesResponseBodyResultProcessList : TeaModel {
                /// <summary>
                /// 图标URL。
                /// </summary>
                [NameInMap("iconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                /// <summary>
                /// 表单名称。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 表单唯一标识。
                /// </summary>
                [NameInMap("processCode")]
                [Validation(Required=false)]
                public string ProcessCode { get; set; }

                /// <summary>
                /// 表单URL。
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
