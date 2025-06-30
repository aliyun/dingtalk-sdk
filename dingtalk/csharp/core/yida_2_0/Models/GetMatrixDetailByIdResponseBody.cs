// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetMatrixDetailByIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMatrixDetailByIdResponseBodyResult Result { get; set; }
        public class GetMatrixDetailByIdResponseBodyResult : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public GetMatrixDetailByIdResponseBodyResultDescription Description { get; set; }
            public class GetMatrixDetailByIdResponseBodyResultDescription : TeaModel {
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

            [NameInMap("matrixData")]
            [Validation(Required=false)]
            public GetMatrixDetailByIdResponseBodyResultMatrixData MatrixData { get; set; }
            public class GetMatrixDetailByIdResponseBodyResultMatrixData : TeaModel {
                [NameInMap("currentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            [NameInMap("matrixId")]
            [Validation(Required=false)]
            public string MatrixId { get; set; }

            [NameInMap("matrixTable")]
            [Validation(Required=false)]
            public GetMatrixDetailByIdResponseBodyResultMatrixTable MatrixTable { get; set; }
            public class GetMatrixDetailByIdResponseBodyResultMatrixTable : TeaModel {
                [NameInMap("conditionColumn")]
                [Validation(Required=false)]
                public List<GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn> ConditionColumn { get; set; }
                public class GetMatrixDetailByIdResponseBodyResultMatrixTableConditionColumn : TeaModel {
                    [NameInMap("columnId")]
                    [Validation(Required=false)]
                    public string ColumnId { get; set; }

                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("resultColumn")]
                [Validation(Required=false)]
                public List<GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn> ResultColumn { get; set; }
                public class GetMatrixDetailByIdResponseBodyResultMatrixTableResultColumn : TeaModel {
                    [NameInMap("columnId")]
                    [Validation(Required=false)]
                    public string ColumnId { get; set; }

                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetMatrixDetailByIdResponseBodyResultName Name { get; set; }
            public class GetMatrixDetailByIdResponseBodyResultName : TeaModel {
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

            [NameInMap("rowTotalCount")]
            [Validation(Required=false)]
            public int? RowTotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
