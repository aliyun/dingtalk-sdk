// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BatchGetFormDataByIdListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchGetFormDataByIdListResponseBodyResult> Result { get; set; }
        public class BatchGetFormDataByIdListResponseBodyResult : TeaModel {
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("formData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultModifyUser ModifyUser { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultModifyUser : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultModifyUserName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultModifyUserName : TeaModel {
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultOriginator Originator { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultOriginator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultOriginatorName : TeaModel {
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
