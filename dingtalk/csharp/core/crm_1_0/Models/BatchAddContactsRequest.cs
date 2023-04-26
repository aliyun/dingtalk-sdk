// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddContactsRequest : TeaModel {
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("relationList")]
        [Validation(Required=false)]
        public List<BatchAddContactsRequestRelationList> RelationList { get; set; }
        public class BatchAddContactsRequestRelationList : TeaModel {
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchAddContactsRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchAddContactsRequestRelationListBizDataList : TeaModel {
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

            [NameInMap("bizExtMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> BizExtMap { get; set; }

        }

    }

}
