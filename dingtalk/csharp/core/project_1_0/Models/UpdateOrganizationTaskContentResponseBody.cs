// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskContentResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskContentResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskContentResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>后天交周报</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-08T07:32:48.958Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
