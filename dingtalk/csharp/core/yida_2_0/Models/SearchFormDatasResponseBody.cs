// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class SearchFormDatasResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDatasResponseBodyData> Data { get; set; }
        public class SearchFormDatasResponseBodyData : TeaModel {
            [NameInMap("createdTimeGMT")]
            [Validation(Required=false)]
            public string CreatedTimeGMT { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("dataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            [NameInMap("formData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("modelUuid")]
            [Validation(Required=false)]
            public string ModelUuid { get; set; }

            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("modifierUserId")]
            [Validation(Required=false)]
            public string ModifierUserId { get; set; }

            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDatasResponseBodyDataModifyUser : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataModifyUserUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataModifyUserUserName : TeaModel {
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDatasResponseBodyDataOriginator : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataOriginatorUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataOriginatorUserName : TeaModel {
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
