// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryConvertRulesResponseBody : TeaModel {
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public long? DingOpenErrcode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryConvertRulesResponseBodyResult Result { get; set; }
        public class QueryConvertRulesResponseBodyResult : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<QueryConvertRulesResponseBodyResultItems> Items { get; set; }
            public class QueryConvertRulesResponseBodyResultItems : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public float? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public float? GmtModified { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ruleBizId")]
                [Validation(Required=false)]
                public string RuleBizId { get; set; }

                [NameInMap("sourceFiles")]
                [Validation(Required=false)]
                public List<QueryConvertRulesResponseBodyResultItemsSourceFiles> SourceFiles { get; set; }
                public class QueryConvertRulesResponseBodyResultItemsSourceFiles : TeaModel {
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileSize")]
                    [Validation(Required=false)]
                    public float? FileSize { get; set; }

                    [NameInMap("fileTag")]
                    [Validation(Required=false)]
                    public string FileTag { get; set; }

                    [NameInMap("mediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    [NameInMap("previewUrl")]
                    [Validation(Required=false)]
                    public string PreviewUrl { get; set; }

                }

                [NameInMap("targetFiles")]
                [Validation(Required=false)]
                public List<QueryConvertRulesResponseBodyResultItemsTargetFiles> TargetFiles { get; set; }
                public class QueryConvertRulesResponseBodyResultItemsTargetFiles : TeaModel {
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileSize")]
                    [Validation(Required=false)]
                    public float? FileSize { get; set; }

                    [NameInMap("fileTag")]
                    [Validation(Required=false)]
                    public string FileTag { get; set; }

                    [NameInMap("mediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    [NameInMap("previewUrl")]
                    [Validation(Required=false)]
                    public string PreviewUrl { get; set; }

                }

            }

            [NameInMap("pageNo")]
            [Validation(Required=false)]
            public float? PageNo { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public float? PageSize { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public float? TotalCount { get; set; }

            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public float? TotalPages { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
