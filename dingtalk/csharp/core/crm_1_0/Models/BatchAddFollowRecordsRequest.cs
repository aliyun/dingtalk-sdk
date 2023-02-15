// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddFollowRecordsRequest : TeaModel {
        /// <summary>
        /// 关系数据列表。
        /// </summary>
        [NameInMap("instanceList")]
        [Validation(Required=false)]
        public List<BatchAddFollowRecordsRequestInstanceList> InstanceList { get; set; }
        public class BatchAddFollowRecordsRequestInstanceList : TeaModel {
            /// <summary>
            /// 关系模型数据。
            /// </summary>
            [NameInMap("dataArray")]
            [Validation(Required=false)]
            public List<BatchAddFollowRecordsRequestInstanceListDataArray> DataArray { get; set; }
            public class BatchAddFollowRecordsRequestInstanceListDataArray : TeaModel {
                /// <summary>
                /// 模型字段extendValue。
                /// </summary>
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                /// <summary>
                /// 模型字段id。
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 模型字段value。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
