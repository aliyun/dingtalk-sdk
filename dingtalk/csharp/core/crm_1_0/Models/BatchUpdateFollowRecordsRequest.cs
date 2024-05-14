// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateFollowRecordsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("instanceList")]
        [Validation(Required=false)]
        public List<BatchUpdateFollowRecordsRequestInstanceList> InstanceList { get; set; }
        public class BatchUpdateFollowRecordsRequestInstanceList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dataArray")]
            [Validation(Required=false)]
            public List<BatchUpdateFollowRecordsRequestInstanceListDataArray> DataArray { get; set; }
            public class BatchUpdateFollowRecordsRequestInstanceListDataArray : TeaModel {
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
