// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetOrganizatioTaskByIdsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOrganizatioTaskByIdsResponseBodyResult> Result { get; set; }
        public class GetOrganizatioTaskByIdsResponseBodyResult : TeaModel {
            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>明天12点前写好周报</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173xxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173xxxx</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

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
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>我是一条备注哦</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-10</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62a010c153c2efxxxxxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>members</para>
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

    }

}
