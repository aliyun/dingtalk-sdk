// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_2_0.Models
{
    public class CreateSheetRequest : TeaModel {
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<CreateSheetRequestFields> Fields { get; set; }
        public class CreateSheetRequestFields : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("property")]
            [Validation(Required=false)]
            public Dictionary<string, object> Property { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
