// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class GetFootprintTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetFootprintTaskResponseBodyResult> Result { get; set; }
        public class GetFootprintTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-19T11:07:51.468Z</para>
            /// </summary>
            [NameInMap("accomplished")]
            [Validation(Required=false)]
            public string Accomplished { get; set; }

            [NameInMap("basicPos")]
            [Validation(Required=false)]
            public string BasicPos { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<GetFootprintTaskResponseBodyResultCustomfields> Customfields { get; set; }
            public class GetFootprintTaskResponseBodyResultCustomfields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>666a472803e46df8ce98a4a5</para>
                /// </summary>
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>date</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Value { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-13T10:00:00.000Z</para>
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test123</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pos")]
            [Validation(Required=false)]
            public long? Pos { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("sfcId")]
            [Validation(Required=false)]
            public string SfcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6639f974916cdb178e7d***</para>
            /// </summary>
            [NameInMap("stageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-13T10:00:00.000Z</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6639f974916cdb178e7d***</para>
            /// </summary>
            [NameInMap("tasklistId")]
            [Validation(Required=false)]
            public string TasklistId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6639f974916cdb178e7****</para>
            /// </summary>
            [NameInMap("tfsId")]
            [Validation(Required=false)]
            public string TfsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>540</para>
            /// </summary>
            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public long? UniqueId { get; set; }

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
