// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_2_0.Models
{
    public class InsertRecordsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<InsertRecordsRequestRecords> Records { get; set; }
        public class InsertRecordsRequestRecords : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fields")]
            [Validation(Required=false)]
            public Dictionary<string, object> Fields { get; set; }

        }

    }

}
