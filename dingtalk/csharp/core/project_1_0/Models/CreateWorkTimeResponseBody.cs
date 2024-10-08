// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateWorkTimeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateWorkTimeResponseBodyResult Result { get; set; }
        public class CreateWorkTimeResponseBodyResult : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public List<CreateWorkTimeResponseBodyResultBody> Body { get; set; }
            public class CreateWorkTimeResponseBodyResultBody : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-09-05T00:00:00.000Z</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>63186e54e07f18003fea6b90</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3600000</para>
                /// </summary>
                [NameInMap("workTime")]
                [Validation(Required=false)]
                public long? WorkTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>创建成功</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("ok")]
            [Validation(Required=false)]
            public bool? Ok { get; set; }

        }

    }

}
