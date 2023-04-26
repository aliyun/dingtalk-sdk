// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddFollowRecordsRequest : TeaModel {
        [NameInMap("instanceList")]
        [Validation(Required=false)]
        public List<BatchAddFollowRecordsRequestInstanceList> InstanceList { get; set; }
        public class BatchAddFollowRecordsRequestInstanceList : TeaModel {
            [NameInMap("dataArray")]
            [Validation(Required=false)]
            public List<BatchAddFollowRecordsRequestInstanceListDataArray> DataArray { get; set; }
            public class BatchAddFollowRecordsRequestInstanceListDataArray : TeaModel {
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

        }

        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
