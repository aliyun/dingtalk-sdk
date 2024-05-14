// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CustomizeContactListResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CustomizeContactListResponseBodyContent> Content { get; set; }
        public class CustomizeContactListResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("rootDeptId")]
            [Validation(Required=false)]
            public long? RootDeptId { get; set; }

        }

    }

}
