// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskExecutorResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskExecutorResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskExecutorResponseBodyResult : TeaModel {
            [NameInMap("executor")]
            [Validation(Required=false)]
            public UpdateOrganizationTaskExecutorResponseBodyResultExecutor Executor { get; set; }
            public class UpdateOrganizationTaskExecutorResponseBodyResultExecutor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxxx">http://xxxxx</a></para>
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

            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<UpdateOrganizationTaskExecutorResponseBodyResultInvolvers> Involvers { get; set; }
            public class UpdateOrganizationTaskExecutorResponseBodyResultInvolvers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxxx">http://xxxxx</a></para>
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
            /// <para>2022-06-08T03:00:17.031Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
