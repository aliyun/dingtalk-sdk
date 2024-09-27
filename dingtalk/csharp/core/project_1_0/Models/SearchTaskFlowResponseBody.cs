// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchTaskFlowResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchTaskFlowResponseBodyResult> Result { get; set; }
        public class SearchTaskFlowResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3b376ecxxxxxxx</para>
            /// </summary>
            [NameInMap("boundToObjectId")]
            [Validation(Required=false)]
            public string BoundToObjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("boundToObjectType")]
            [Validation(Required=false)]
            public string BoundToObjectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>07151530111xxxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>工作流1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60a2187eb72xxxxxxx</para>
            /// </summary>
            [NameInMap("taskflowId")]
            [Validation(Required=false)]
            public string TaskflowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
