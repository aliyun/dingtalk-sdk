// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskPriorityResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskPriorityResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskPriorityResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>-10</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-13T06:02:44.835Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
