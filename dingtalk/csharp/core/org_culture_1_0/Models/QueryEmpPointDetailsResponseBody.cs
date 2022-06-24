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
                public long? Amount { get; set; }
                public long? GmtCreate { get; set; }
                public string OutId { get; set; }
                public QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO PointOperateFeatureResponseDTO { get; set; }
                public class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO : TeaModel {
                    /// <summary>
                    /// 来源账户
                    /// </summary>
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
                    };

                    /// <summary>
                    /// 目标账户
                    /// 
                    /// </summary>
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
                    };

                    /// <summary>
                    /// 备注信息，在明细中展示
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// 来源/用途，一般是系统固定的场景
                    /// </summary>
                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }
                public string SourceBizCode { get; set; }
            }
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
        };

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
