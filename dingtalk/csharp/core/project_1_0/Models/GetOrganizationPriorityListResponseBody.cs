// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetOrganizationPriorityListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOrganizationPriorityListResponseBodyResult> Result { get; set; }
        public class GetOrganizationPriorityListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>blue</para>
            /// </summary>
            [NameInMap("color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>普通</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5e870bc35b79b70xxxxx</para>
            /// </summary>
            [NameInMap("priorityId")]
            [Validation(Required=false)]
            public string PriorityId { get; set; }

        }

    }

}
