// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryAllFormInstancesResponseBody : TeaModel {
        /// <summary>
        /// 分页结果
        /// </summary>
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
                public string FormInstanceId { get; set; }
                public string AppUuid { get; set; }
                public string FormCode { get; set; }
                public string Title { get; set; }
                public string Creator { get; set; }
                public string Modifier { get; set; }
                public long? CreateTimestamp { get; set; }
                public long? ModifyTimestamp { get; set; }
                public string OutInstanceId { get; set; }
                public string OutBizCode { get; set; }
                public Dictionary<string, string> Attributes { get; set; }
                public List<QueryAllFormInstancesResponseBodyResultValuesFormInstDataList> FormInstDataList { get; set; }
                public class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList : TeaModel {
                    public string ComponentType { get; set; }
                    public string BizAlias { get; set; }
                    public string ExtendValue { get; set; }
                    public string Label { get; set; }
                    public string Value { get; set; }
                    public string Key { get; set; }
                }
            }
        };

    }

}
