// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class SearchFormDataSecondGenerationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDataSecondGenerationResponseBodyData> Data { get; set; }
        public class SearchFormDataSecondGenerationResponseBodyData : TeaModel {
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
            public SearchFormDataSecondGenerationResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDataSecondGenerationResponseBodyDataModifyUser : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public SearchFormDataSecondGenerationResponseBodyDataModifyUserName Name { get; set; }
                public class SearchFormDataSecondGenerationResponseBodyDataModifyUserName : TeaModel {
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
            public SearchFormDataSecondGenerationResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDataSecondGenerationResponseBodyDataOriginator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public SearchFormDataSecondGenerationResponseBodyDataOriginatorName Name { get; set; }
                public class SearchFormDataSecondGenerationResponseBodyDataOriginatorName : TeaModel {
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

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
