// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateFollowRecordsRequest : TeaModel {
        [NameInMap("instanceList")]
        [Validation(Required=false)]
        public List<BatchUpdateFollowRecordsRequestInstanceList> InstanceList { get; set; }
        public class BatchUpdateFollowRecordsRequestInstanceList : TeaModel {
            [NameInMap("dataArray")]
            [Validation(Required=false)]
            public List<BatchUpdateFollowRecordsRequestInstanceListDataArray> DataArray { get; set; }
            public class BatchUpdateFollowRecordsRequestInstanceListDataArray : TeaModel {
                [NameInMap("extendValue")]
                [Validation(Required=false)]
                public string ExtendValue { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
