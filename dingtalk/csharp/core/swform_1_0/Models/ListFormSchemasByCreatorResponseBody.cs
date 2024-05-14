// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormSchemasByCreatorResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFormSchemasByCreatorResponseBodyResult Result { get; set; }
        public class ListFormSchemasByCreatorResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListFormSchemasByCreatorResponseBodyResultList> List { get; set; }
            public class ListFormSchemasByCreatorResponseBodyResultList : TeaModel {
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("setting")]
                [Validation(Required=false)]
                public ListFormSchemasByCreatorResponseBodyResultListSetting Setting { get; set; }
                public class ListFormSchemasByCreatorResponseBodyResultListSetting : TeaModel {
                    [NameInMap("bizType")]
                    [Validation(Required=false)]
                    public int? BizType { get; set; }

                    /// <summary>
                    /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                    /// </summary>
                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("formType")]
                    [Validation(Required=false)]
                    public int? FormType { get; set; }

                    [NameInMap("loopDays")]
                    [Validation(Required=false)]
                    public List<int?> LoopDays { get; set; }

                    [NameInMap("loopTime")]
                    [Validation(Required=false)]
                    public string LoopTime { get; set; }

                    [NameInMap("stop")]
                    [Validation(Required=false)]
                    public bool? Stop { get; set; }

                }

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
