// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryAllFormInstancesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryAllFormInstancesResponseBodyResult Result { get; set; }
        public class QueryAllFormInstancesResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<QueryAllFormInstancesResponseBodyResultValues> Values { get; set; }
            public class QueryAllFormInstancesResponseBodyResultValues : TeaModel {
                [NameInMap("appUuid")]
                [Validation(Required=false)]
                public string AppUuid { get; set; }

                [NameInMap("attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                [NameInMap("formInstDataList")]
                [Validation(Required=false)]
                public List<QueryAllFormInstancesResponseBodyResultValuesFormInstDataList> FormInstDataList { get; set; }
                public class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList : TeaModel {
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    [NameInMap("extendValue")]
                    [Validation(Required=false)]
                    public string ExtendValue { get; set; }

                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("formInstanceId")]
                [Validation(Required=false)]
                public string FormInstanceId { get; set; }

                [NameInMap("modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("modifyTimestamp")]
                [Validation(Required=false)]
                public long? ModifyTimestamp { get; set; }

                [NameInMap("outBizCode")]
                [Validation(Required=false)]
                public string OutBizCode { get; set; }

                [NameInMap("outInstanceId")]
                [Validation(Required=false)]
                public string OutInstanceId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
