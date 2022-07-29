// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormInstancesResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFormInstancesResponseBodyResult Result { get; set; }
        public class ListFormInstancesResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListFormInstancesResponseBodyResultList> List { get; set; }
            public class ListFormInstancesResponseBodyResultList : TeaModel {
                public string CreateTime { get; set; }
                public string FormCode { get; set; }
                public string FormInstanceId { get; set; }
                public List<ListFormInstancesResponseBodyResultListForms> Forms { get; set; }
                public class ListFormInstancesResponseBodyResultListForms : TeaModel {
                    public string Key { get; set; }
                    public string Label { get; set; }
                    public string Value { get; set; }
                }
                public string ModifyTime { get; set; }
                public string StudentClassId { get; set; }
                public string StudentClassName { get; set; }
                public string StudentName { get; set; }
                public string StudentUserId { get; set; }
                public string SubmitterUserId { get; set; }
                public string SubmitterUserName { get; set; }
                public string Title { get; set; }
            }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
