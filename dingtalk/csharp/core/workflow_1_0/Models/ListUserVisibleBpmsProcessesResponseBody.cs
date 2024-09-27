// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListUserVisibleBpmsProcessesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListUserVisibleBpmsProcessesResponseBodyResult Result { get; set; }
        public class ListUserVisibleBpmsProcessesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

            [NameInMap("processList")]
            [Validation(Required=false)]
            public List<ListUserVisibleBpmsProcessesResponseBodyResultProcessList> ProcessList { get; set; }
            public class ListUserVisibleBpmsProcessesResponseBodyResultProcessList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12347899</para>
                /// </summary>
                [NameInMap("dirId")]
                [Validation(Required=false)]
                public string DirId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>财务管理</para>
                /// </summary>
                [NameInMap("dirName")]
                [Validation(Required=false)]
                public string DirName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://gw.xxxx/T-102-102.png">https://gw.xxxx/T-102-102.png</a></para>
                /// </summary>
                [NameInMap("iconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>物品领用</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PROC-YMLA1-xxxx-11WFJ-1</para>
                /// </summary>
                [NameInMap("processCode")]
                [Validation(Required=false)]
                public string ProcessCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://aflow.dingtalk.com/dingtalk/mobile/homepage.htm?xxxx">https://aflow.dingtalk.com/dingtalk/mobile/homepage.htm?xxxx</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
