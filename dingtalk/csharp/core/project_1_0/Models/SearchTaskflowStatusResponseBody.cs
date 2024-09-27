// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchTaskflowStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchTaskflowStatusResponseBodyResult> Result { get; set; }
        public class SearchTaskflowStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>601fdeb17f86xxxxxxxx</para>
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
            /// <para>false</para>
            /// </summary>
            [NameInMap("isTaskflowstatusruleexector")]
            [Validation(Required=false)]
            public bool? IsTaskflowstatusruleexector { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>未开始</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            [NameInMap("rejectStatusIds")]
            [Validation(Required=false)]
            public List<string> RejectStatusIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60a2187eb72xxxxxxx</para>
            /// </summary>
            [NameInMap("taskflowId")]
            [Validation(Required=false)]
            public string TaskflowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60a2187eb72xxxxxxx</para>
            /// </summary>
            [NameInMap("taskflowStatusId")]
            [Validation(Required=false)]
            public string TaskflowStatusId { get; set; }

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
