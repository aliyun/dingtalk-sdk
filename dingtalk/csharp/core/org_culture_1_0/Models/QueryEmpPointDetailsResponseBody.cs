// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryEmpPointDetailsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryEmpPointDetailsResponseBodyResult Result { get; set; }
        public class QueryEmpPointDetailsResponseBodyResult : TeaModel {
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<QueryEmpPointDetailsResponseBodyResultDetails> Details { get; set; }
            public class QueryEmpPointDetailsResponseBodyResultDetails : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("pointOperateFeatureResponseDTO")]
                [Validation(Required=false)]
                public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO PointOperateFeatureResponseDTO { get; set; }
                public class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO : TeaModel {
                    [NameInMap("accountSource")]
                    [Validation(Required=false)]
                    public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource AccountSource { get; set; }
                    public class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource : TeaModel {
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }

                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    [NameInMap("accountTarget")]
                    [Validation(Required=false)]
                    public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget AccountTarget { get; set; }
                    public class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget : TeaModel {
                        [NameInMap("accountType")]
                        [Validation(Required=false)]
                        public string AccountType { get; set; }

                        [NameInMap("empName")]
                        [Validation(Required=false)]
                        public string EmpName { get; set; }

                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sourceBizCode")]
                [Validation(Required=false)]
                public string SourceBizCode { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
