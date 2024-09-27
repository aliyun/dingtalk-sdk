// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskStatusResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-08T07:32:48.958Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
