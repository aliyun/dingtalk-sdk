// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateContactsRequest : TeaModel {
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("relationList")]
        [Validation(Required=false)]
        public List<BatchUpdateContactsRequestRelationList> RelationList { get; set; }
        public class BatchUpdateContactsRequestRelationList : TeaModel {
            [NameInMap("bizDataList")]
            [Validation(Required=false)]
            public List<BatchUpdateContactsRequestRelationListBizDataList> BizDataList { get; set; }
            public class BatchUpdateContactsRequestRelationListBizDataList : TeaModel {
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

            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

        }

    }

}
