// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateOrganizationTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateOrganizationTaskResponseBodyResult Result { get; set; }
        public class CreateOrganizationTaskResponseBodyResult : TeaModel {
            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("attachmentsCount")]
            [Validation(Required=false)]
            public int? AttachmentsCount { get; set; }

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

            [NameInMap("creator")]
            [Validation(Required=false)]
            public CreateOrganizationTaskResponseBodyResultCreator Creator { get; set; }
            public class CreateOrganizationTaskResponseBodyResultCreator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxxxxxxxx">https://xxxxxxxxxx</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>鬼斩</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>173xxxx</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

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

            [NameInMap("executor")]
            [Validation(Required=false)]
            public CreateOrganizationTaskResponseBodyResultExecutor Executor { get; set; }
            public class CreateOrganizationTaskResponseBodyResultExecutor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxxxxxxxx">https://xxxxxxxxxx</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>鬼斩</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>173xxxx</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173xxxx</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("hasReminder")]
            [Validation(Required=false)]
            public bool? HasReminder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62a697c053c2ef5xxxxxx</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<CreateOrganizationTaskResponseBodyResultInvolvers> Involvers { get; set; }
            public class CreateOrganizationTaskResponseBodyResultInvolvers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>httpx://xxx</para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>173xxxx</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>鬼斩</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

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
            public string IsDone { get; set; }

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
