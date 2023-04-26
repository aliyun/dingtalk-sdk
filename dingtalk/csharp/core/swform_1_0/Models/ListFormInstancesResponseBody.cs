// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormInstancesResponseBody : TeaModel {
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
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                [NameInMap("formInstanceId")]
                [Validation(Required=false)]
                public string FormInstanceId { get; set; }

                [NameInMap("forms")]
                [Validation(Required=false)]
                public List<ListFormInstancesResponseBodyResultListForms> Forms { get; set; }
                public class ListFormInstancesResponseBodyResultListForms : TeaModel {
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

                [NameInMap("modifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("studentClassId")]
                [Validation(Required=false)]
                public string StudentClassId { get; set; }

                [NameInMap("studentClassName")]
                [Validation(Required=false)]
                public string StudentClassName { get; set; }

                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                [NameInMap("studentUserId")]
                [Validation(Required=false)]
                public string StudentUserId { get; set; }

                [NameInMap("submitterUserId")]
                [Validation(Required=false)]
                public string SubmitterUserId { get; set; }

                [NameInMap("submitterUserName")]
                [Validation(Required=false)]
                public string SubmitterUserName { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
